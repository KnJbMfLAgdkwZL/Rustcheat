using System;
using System.Linq;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Concurrent;
using UnityEngine;
using Graphics = System.Drawing.Graphics;
using Rust_Interceptor.Data;

namespace ConsoleApplication1
{
    public class Radar
    {
        private ConcurrentDictionary<String, Entity> others = new ConcurrentDictionary<String, Entity>();
        private ConcurrentDictionary<String, Entity> players = new ConcurrentDictionary<String, Entity>();

        public ushort Increment = 0;

        public Settings settings;
        private Entity player;
        private Graphics gForm;
        private Bitmap bufer;
        private Graphics buferGraphics;

        public Radar(Form1 form)
        {
            this.settings = form.radarSettings.settings;
            this.settings.TransparencyKey = form.TransparencyKey;

            this.createBuffer();
            this.gForm = Graphics.FromHwnd(form.Handle);

            Timer timer = new Timer();
            timer.Interval = 100;
            timer.Tick += timer_Tick;
            timer.Start();
        }

        public void createBuffer()
        {
            if (this.bufer != null)
            {
                this.bufer.Dispose();
            }
            if (this.buferGraphics != null)
            {
                this.buferGraphics.Dispose();
            }

            this.bufer = new Bitmap(this.settings.buferSize, this.settings.buferSize);
            this.buferGraphics = Graphics.FromImage(this.bufer);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            this.Increment++;
            if (this.Increment >= 300)
            {
                this.Increment = 0;
                this.players.Clear();
            }

            if (this.settings.buferSize > this.bufer.Width || this.settings.buferSize > this.bufer.Height)
            {
                this.createBuffer();
                this.gForm.Clear(this.settings.TransparencyKey);
            }

            this.buferGraphics.Clear(this.settings.TransparencyKey);
            this.DrawRadar();
            this.DrawPlayers();
            this.gForm.DrawImageUnscaled(this.bufer, 0, 0, this.settings.buferSize, this.settings.buferSize);
        }

        public void SetCurPlayer(Entity playerPassed)
        {
            player = playerPassed;
        }

        private Vector2 RotatePoint(Vector2 pointToRotate, Vector2 centerPoint, float angle)
        {
            angle = (float) (angle*(Math.PI/180f));
            float cosTheta = (float) Math.Cos(angle);
            float sinTheta = (float) Math.Sin(angle);
            Vector2 returnVec = new Vector2(
                cosTheta*(pointToRotate.x - centerPoint.x) - sinTheta*(pointToRotate.y - centerPoint.y),
                sinTheta*(pointToRotate.x - centerPoint.x) + cosTheta*(pointToRotate.y - centerPoint.y)
                );
            returnVec += centerPoint;
            return returnVec;
        }

        public void DrawRadar()
        {
            this.buferGraphics.DrawEllipse(
                this.settings.radarP,
                0, 0,
                this.settings.sizeRadar, this.settings.sizeRadar);

            this.buferGraphics.DrawEllipse(
                this.settings.radarP,
                this.settings.radPosX,
                this.settings.radPosY,
                this.settings.sizeDot,
                this.settings.sizeDot);

            this.buferGraphics.FillEllipse(
                this.settings.radarB,
                this.settings.radPosX,
                this.settings.radPosY,
                this.settings.sizeDot,
                this.settings.sizeDot);
        }

        public Vector2 converterToVector(Vector3 vector)
        {
            return new Vector2(vector.x, vector.z);
        }

        public Brush GetColorB(Entity entity)
        {
            if (entity.IsPlayer)
            {
                String name = entity.Data.basePlayer.name;
                if (this.settings.friends.Contains(name))
                {
                    return this.settings.friendB;
                }
                else
                {
                    return this.settings.playerB;
                }
            }
            if (entity.Data.autoturret != null)
            {
                return this.settings.autoturretB;
            }
            if (entity.Data.resource != null)
            {
                return this.settings.resourceB;
            }
            if (entity.Data.plantEntity != null)
            {
                return this.settings.plantEntityB;
            }

            return this.settings.storageBoxB;
        }

        public Pen GetColorP(Entity entity)
        {
            if (entity.IsPlayer)
            {
                String name = entity.Data.basePlayer.name;
                if (this.settings.friends.Contains(name))
                {
                    return this.settings.friendP;
                }
                else
                {
                    return this.settings.playerP;
                }
            }
            if (entity.Data.autoturret != null)
            {
                return this.settings.autoturretP;
            }
            if (entity.Data.resource != null)
            {
                return this.settings.resourceP;
            }
            if (entity.Data.plantEntity != null)
            {
                return this.settings.plantEntityP;
            }

            return this.settings.storageBoxP;
        }
         
        public void DrawPlayers()
        {
            float rotationAngle = 0;
            if (this.player != null)
            {
                rotationAngle = (this.player.Rotation.y + 180);
            }
            foreach (KeyValuePair<String, Entity> val in this.players)
            {
                //Vector2 rotatedPosition = this.DrawPoint(val.Value, rotationAngle);
                Vector2 rotatedPosition = this.DrawPointPlayer(val.Value, rotationAngle);
                if (this.settings.showName)
                {
                    String name = val.Value.Data.basePlayer.name;
                    Brush brush = this.GetColorB(val.Value);
                    this.buferGraphics.DrawString(name, this.settings.font, brush, rotatedPosition.x, rotatedPosition.y);
                }
            }

            foreach (KeyValuePair<String, Entity> val in this.others)
            {
                this.DrawPoint(val.Value, rotationAngle);
            }
        }

        public Vector2 DrawPoint(Entity val, float rotationAngle)
        {
            Vector2 relativePosition = this.RotatePoint(
                this.converterToVector(val.Position),
                this.converterToVector(player.Position),
                rotationAngle);

            Vector2 bydloCode = relativePosition - this.converterToVector(player.Position);
            bydloCode.x = -bydloCode.x;
            Vector2 rotatedPosition = bydloCode + this.settings.centerCircle;

            Brush brush = this.GetColorB(val);

            this.buferGraphics.FillEllipse(brush,
                rotatedPosition.x - this.settings.halfdot,
                rotatedPosition.y - this.settings.halfdot,
                this.settings.sizeDot,
                this.settings.sizeDot);

            return rotatedPosition;
        }

        public Vector2 UnitX = new Vector2(1.0f, 0.0f);
        public Vector2 UnitY = new Vector2(0.0f, 1.0f);
        public int PLAYER_FOV_SIZE = 8;
        public Vector2 DrawPointPlayer(Entity val, float rotationAngle)
        {
            Vector2 relativePosition = this.RotatePoint(
                this.converterToVector(val.Position),
                this.converterToVector(player.Position),
                rotationAngle);

            Vector2 bydloCode = relativePosition - this.converterToVector(player.Position);
            bydloCode.x = -bydloCode.x;
            Vector2 rotatedPosition = bydloCode + this.settings.centerCircle;

            Brush brush = this.GetColorB(val);

            this.buferGraphics.FillEllipse(brush,
                rotatedPosition.x - this.settings.halfdot,
                rotatedPosition.y - this.settings.halfdot,
                this.settings.sizeDot,
                this.settings.sizeDot);

            //FOV ENEMY
            //Prepare FOV
            Vector2[] fov = new Vector2[3];
            fov[0] = rotatedPosition;
            fov[1] = rotatedPosition - UnitY*PLAYER_FOV_SIZE + UnitX*PLAYER_FOV_SIZE;
            fov[2] = rotatedPosition - UnitY*PLAYER_FOV_SIZE - UnitX*PLAYER_FOV_SIZE;
            //Rotate FOV according to this player's and localPlayer's yaw
            float rotationAngle_Point = (val.Rotation.y + 180);
            float rottmp = rotationAngle - rotationAngle_Point;
            rottmp = -rottmp;

            fov[1] = this.RotatePoint(fov[1], rotatedPosition, rottmp);
            fov[2] = this.RotatePoint(fov[2], rotatedPosition, rottmp);
            PointF[] fov_pointf = new PointF[3]
            {
                new PointF(fov[0].x, fov[0].y),
                new PointF(fov[1].x, fov[1].y),
                new PointF(fov[2].x, fov[2].y),
            };
            //Draw FOV
            Pen pen = this.GetColorP(val);
            this.buferGraphics.DrawPolygon(pen, fov_pointf);

            return rotatedPosition;
        }

        public void AddOrUpdatePlayers(Entity entity)
        {
            String key = entity.UID.ToString();
            this.players.AddOrUpdate(key, entity, (oldkey, oldvalue) => entity);
        }

        public void AddOrUpdateOthers(Entity entity)
        {
            String key = entity.UID.ToString();
            this.others.AddOrUpdate(key, entity, (oldkey, oldvalue) => entity);
        }

        public void DeleteOthers(uint UID)
        {
            String key = UID.ToString();
            Entity entity;
            this.others.TryRemove(key, out entity);
        }
    }
}
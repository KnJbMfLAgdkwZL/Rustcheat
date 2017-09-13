using Rust_Interceptor;
using Rust_Interceptor.Data;
using System.Linq;

namespace ConsoleApplication1
{
    internal class MyInterceptor : SimpleInterceptor
    {
        public Form1 form;
        public Radar radar;
        public Settings settings;

        private uint[] barrels = new uint[]
        {
            651787397, //"assets/bundled/prefabs/autospawn/resource/loot/loot-barrel-1.prefab"
            2394597732, //"assets/bundled/prefabs/autospawn/resource/loot/loot-barrel-2.prefab"
            2597142830, //"assets/bundled/prefabs/fx/entities/loot_barrel/gib.prefab"
            997778416, //"assets/bundled/prefabs/fx/entities/loot_barrel/impact.prefab"
            3046822692, //"assets/bundled/prefabs/radtown/loot_barrel_1.prefab"
            494665731, //"assets/bundled/prefabs/radtown/loot_barrel_2.prefab"
            1742295134, //"assets/bundled/prefabs/radtown/oil_barrel.prefab"
            2597142830, //"assets/bundled/prefabs/fx/entities/loot_barrel/gib.prefab"
            997778416, //"assets/bundled/prefabs/fx/entities/loot_barrel/impact.prefab"
        };

        private uint[] crates = new uint[]
        {
            3575688258, //"assets/bundled/prefabs/radtown/crate_mine.prefab"
            311943278, //"assets/bundled/prefabs/radtown/crate_normal.prefab"
            184186459, //"assets/bundled/prefabs/radtown/crate_normal_2.prefab"
            319002060, //"assets/bundled/prefabs/radtown/crate_normal_2_food.prefab"
            1181989833, //"assets/bundled/prefabs/radtown/crate_normal_2_medical.prefab"
            3724016788, //"assets/bundled/prefabs/radtown/crate_tools.prefab"
            673144215, //"assets/bundled/prefabs/ui/lootpanels/lootpanel.crate.prefab"
            1578282492, //"assets/content/props/wooden_crates/crate_cover_300x600.prefab"
            2346521855, //"assets/content/props/wooden_crates/wooden_crate_a.prefab"
            2122804845, //"assets/content/props/wooden_crates/wooden_crate_a_red.prefab"
            4089332190, //"assets/content/props/wooden_crates/wooden_crate_b.prefab"
            2251887564, //"assets/content/props/wooden_crates/wooden_crate_b_red.prefab"
            1537175229, //"assets/content/props/wooden_crates/wooden_crate_c.prefab"
            2380970283, //"assets/content/props/wooden_crates/wooden_crate_c_red.prefab"
            3279985564, //"assets/content/props/wooden_crates/wooden_crate_d.prefab"
            2510053002, //"assets/content/props/wooden_crates/wooden_crate_d_red.prefab"
            727828603, //"assets/content/props/wooden_crates/wooden_crate_e.prefab"
            2639135721, //"assets/content/props/wooden_crates/wooden_crate_e_red.prefab"
        };

        private uint[] loots = new uint[]
        {
            651787397, //"assets/bundled/prefabs/autospawn/resource/loot/loot-barrel-1.prefab"
            2394597732, //"assets/bundled/prefabs/autospawn/resource/loot/loot-barrel-2.prefab"
            2690357381, //"assets/bundled/prefabs/autospawn/resource/loot/trash-pile-1.prefab"
            2597142830, //"assets/bundled/prefabs/fx/entities/loot_barrel/gib.prefab"
            997778416, //"assets/bundled/prefabs/fx/entities/loot_barrel/impact.prefab"
            1637759034, //"assets/bundled/prefabs/fx/notice/loot.copy.fx.prefab"
            265309823, //"assets/bundled/prefabs/fx/notice/loot.drag.dropsuccess.fx.prefab"
            2859046789, //"assets/bundled/prefabs/fx/notice/loot.drag.grab.fx.prefab"
            1925680827, //"assets/bundled/prefabs/fx/notice/loot.drag.itemdrop.fx.prefab"
            3831275681, //"assets/bundled/prefabs/fx/notice/loot.start.fx.prefab"
            1051159146, //"assets/bundled/prefabs/radtown/dmloot/dm ammo.prefab"
            678924583, //"assets/bundled/prefabs/radtown/dmloot/dm c4.prefab"
            153448738, //"assets/bundled/prefabs/radtown/dmloot/dm construction resources.prefab"
            4228058924, //"assets/bundled/prefabs/radtown/dmloot/dm construction tools.prefab"
            3247291098, //"assets/bundled/prefabs/radtown/dmloot/dm food.prefab"
            2759971835, //"assets/bundled/prefabs/radtown/dmloot/dm medical.prefab"
            3467975258, //"assets/bundled/prefabs/radtown/dmloot/dm tier1 lootbox.prefab"
            2957441081, //"assets/bundled/prefabs/radtown/dmloot/dm tier2 lootbox.prefab"
            2446906904, //"assets/bundled/prefabs/radtown/dmloot/dm tier3 lootbox.prefab"
            3046822692, //"assets/bundled/prefabs/radtown/loot_barrel_1.prefab"
            494665731, //"assets/bundled/prefabs/radtown/loot_barrel_2.prefab"
            4041321320, //"assets/bundled/prefabs/radtown/loot_component_test.prefab"
            1577697392, //"assets/bundled/prefabs/radtown/loot_trash.prefab"
            2507958379, //"assets/bundled/prefabs/ui/lootpanels/lootpanel.autoturret.prefab"
            2720467603, //"assets/bundled/prefabs/ui/lootpanels/lootpanel.campfire.prefab"
            673144215, //"assets/bundled/prefabs/ui/lootpanels/lootpanel.crate.prefab"
            386475285, //"assets/bundled/prefabs/ui/lootpanels/lootpanel.fuelstorage.prefab"
            2230415458, //"assets/bundled/prefabs/ui/lootpanels/lootpanel.furnace.prefab"
            109491971, //"assets/bundled/prefabs/ui/lootpanels/lootpanel.generic.prefab"
            3029343348, //"assets/bundled/prefabs/ui/lootpanels/lootpanel.lantern.prefab"
            2635754061, //"assets/bundled/prefabs/ui/lootpanels/lootpanel.largefurnace.prefab"
            3136533735, //"assets/bundled/prefabs/ui/lootpanels/lootpanel.largewoodbox.prefab"
            109517536, //"assets/bundled/prefabs/ui/lootpanels/lootpanel.player_corpse.prefab"
            1052629387, //"assets/bundled/prefabs/ui/lootpanels/lootpanel.recycler.prefab"
            3272800407, //"assets/bundled/prefabs/ui/lootpanels/lootpanel.repairbench.prefab"
            1044552775, //"assets/bundled/prefabs/ui/lootpanels/lootpanel.researchtable.prefab"
            1269668455, //"assets/bundled/prefabs/ui/lootpanels/lootpanel.shopfront.prefab"
            1016996575, //"assets/bundled/prefabs/ui/lootpanels/lootpanel.smallrefinery.prefab"
            2392469788, //"assets/bundled/prefabs/ui/lootpanels/lootpanel.smallstash.prefab"
            319060403, //"assets/bundled/prefabs/ui/lootpanels/lootpanel.smallwoodbox.prefab"
            1316618680, //"assets/bundled/prefabs/ui/lootpanels/lootpanel.vendingmachine.customer.prefab"
            753840051, //"assets/bundled/prefabs/ui/lootpanels/lootpanel.vendingmachine.storage.prefab"
            1618279897, //"assets/bundled/prefabs/ui/lootpanels/lootpanel.watercatcher.prefab"
        };

        public MyInterceptor(Form1 form1)
            : base()
        {
            this.form = form1;
            this.radar = this.form.radar;
            this.settings = this.form.radarSettings.settings;
            
            Interceptor.AddPacketsToFilter(Packet.Rust.ConsoleCommand, Packet.Rust.ConsoleMessage);
            // Filter packets, you will only receive the packets defined in this function, remove this line to receive all packets
            Interceptor.ClientPackets = true;
            // Receive client packets, in this example you would receive both Server and Client Packets
            Interceptor.CommandPrefix = "RI.";
            // Command Prefix for "sv" command, in this example you could send a command to this program with "sv RI.randomValue 24" and receive OnCommand("randomValue 24")
            Interceptor.Start();
        }

        public override void OnCommand(string command)
        {
            if (command.StartsWith("randomValue"))
            {
                //var str = command.Split(' ');
                //Console.WriteLine("{0} = {1}", str[0], int.Parse(str[1]));
            }
        }

        public override void OnPacket(Packet packet)
        {
            switch (packet.rustID)
            {
                case Packet.Rust.ConsoleMessage:
                    //ConsoleMessage message = new ConsoleMessage(packet);
                    //Console.WriteLine("Console Message from Server: {0}", message.Message);
                    break;
            }
        }

        public override void OnEntity(Entity entity)
        {
            if (entity.IsPlayer)
            {
                if (entity.IsLocalPlayer)
                {
                    this.form.radar.SetCurPlayer(entity);
                }
                else
                {
                    if (entity.Data.basePlayer.modelState.sleeping)
                    {
                    }
                    else
                    {
                        this.radar.AddOrUpdatePlayers(entity);
                    }
                }
            }
            if (entity.Data.autoturret != null)
            {
                this.radar.AddOrUpdateOthers(entity);
            }
            if (entity.Data.resource != null)
            {
                this.radar.AddOrUpdateOthers(entity);
            }

            if (entity.Data.baseNetworkable != null)
            {
                uint prefabID = entity.Data.baseNetworkable.prefabID;
                if (this.barrels.Contains(prefabID))
                {
                    this.radar.AddOrUpdateOthers(entity);
                }
                else if (this.crates.Contains(prefabID))
                {
                    this.radar.AddOrUpdateOthers(entity);
                }
                else if (this.loots.Contains(prefabID))
                {
                    this.radar.AddOrUpdateOthers(entity);
                }
            }
            if (entity.Data.corpse != null)
            {
                this.radar.AddOrUpdateOthers(entity);
            }
            if (entity.Data.lootableCorpse != null)
            {
                this.radar.AddOrUpdateOthers(entity);
            }
            if (entity.Data.loot != null)
            {
                this.radar.AddOrUpdateOthers(entity);
            }

            if (entity.Data.plantEntity != null)
            {
                this.radar.AddOrUpdateOthers(entity);
            }
        }

        public override void OnEntityDestroy(EntityDestroy destroyInfo)
        {
            this.radar.DeleteOthers(destroyInfo.UID);
            //Console.WriteLine("Entity with UID({0}) got destroyed :'(", destroyInfo.UID);
        }
    }
}
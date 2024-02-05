using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using Component;
using Database;
using System.Threading;


namespace aplikasi_bel_sekolah
{
    class Program

    {
        public static AccessDatabaseHelper DB = new AccessDatabaseHelper("./bel.accdb");

        static void Main(string[] args)
        {
            
            Console.CursorVisible = false;

            new Clear(1, 6, 30, 18).SetBackColor(ConsoleColor.Gray).Tampil();
            new Clear(1, 25, 108, 3).SetBackColor(ConsoleColor.Gray).Tampil();
            new Clear(31, 6, 78, 18).SetBackColor(ConsoleColor.Gray).Tampil();
            new Kotak().SetXY(0, 0).SetWidthAndHeight(65, 5).SetBackColor(ConsoleColor.Gray).SetForeColor(ConsoleColor.DarkMagenta).Tampil();
            new Kotak().SetXY(66, 0).SetWidthAndHeight(42, 5).SetBackColor(ConsoleColor.Gray).SetForeColor(ConsoleColor.DarkMagenta).Tampil();
            new Kotak().SetXY(0, 25).SetWidthAndHeight(108, 3).SetBackColor(ConsoleColor.Gray).SetForeColor(ConsoleColor.DarkMagenta).Tampil();
            new Kotak().SetXY(0, 6).SetWidthAndHeight(30, 18).SetBackColor(ConsoleColor.Gray).SetForeColor(ConsoleColor.DarkMagenta).Tampil();
            new Kotak().SetXY(31, 6).SetWidthAndHeight(77, 18).SetBackColor(ConsoleColor.Gray).SetForeColor(ConsoleColor.DarkMagenta).Tampil();
            new Kotak().SetXY(109, 0).SetWidthAndHeight(10, 28).SetBackColor(ConsoleColor.Gray).SetForeColor(ConsoleColor.DarkMagenta).Tampil();

            new Tulisan().SetXY(1, 1).SetLength(8).SetText("  ████████████████████████████████████████████████████████████  ").SetBackColor(ConsoleColor.Gray).SetForeColor(ConsoleColor.DarkMagenta).Tampil();
            new Tulisan().SetXY(1, 2).SetLength(8).SetText("  █▄─▄─▀█▄─▄▄─█▄─▄█████─▄▄▄▄█▄─▄▄─█▄─█─▄█─▄▄─█▄─▄████▀▄─██─█─█  ").SetBackColor(ConsoleColor.Gray).SetForeColor(ConsoleColor.DarkMagenta).Tampil();
            new Tulisan().SetXY(1, 3).SetLength(8).SetText("  ██─▄─▀██─▄█▀██─██▀███▄▄▄▄─██─▄█▀██─▄▀██─██─██─██▀██─▀─██─▄─█  ").SetBackColor(ConsoleColor.Gray).SetForeColor(ConsoleColor.DarkMagenta).Tampil();
            new Tulisan().SetXY(1, 4).SetLength(8).SetText("  ▀▄▄▄▄▀▀▄▄▄▄▄▀▄▄▄▄▄▀▀▀▄▄▄▄▄▀▄▄▄▄▄▀▄▄▀▄▄▀▄▄▄▄▀▄▄▄▄▄▀▄▄▀▄▄▀▄▀▄▀  ").SetBackColor(ConsoleColor.Gray).SetForeColor(ConsoleColor.DarkMagenta).Tampil();
            
            

            new Tulisan().SetXY(1, 26).SetLength(8).SetText("█▀█ █▀█ █▀█ ░░█ █▀▀ █▀▀ ▀█▀  ▄█   ▄▄  ▄▀█ █░░ █░█ █ ▄▀█ █▄░█   █░█░█ ▄▀█ █░█ █▄█ █░█   █▀▄  ▄▄  █ █▄▀   ▀█ ").SetBackColor(ConsoleColor.Gray).SetForeColor(ConsoleColor.DarkMagenta).Tampil();
            new Tulisan().SetXY(1, 27).SetLength(8).SetText("█▀▀ █▀▄ █▄█ █▄█ ██▄ █▄▄ ░█░  ░█   ░░  █▀█ █▄▄ ▀▄▀ █ █▀█ █░▀█   ▀▄▀▄▀ █▀█ █▀█ ░█░ █▄█   █▄▀  ░░  █ █░█   █▄ ").SetBackColor(ConsoleColor.Gray).SetForeColor(ConsoleColor.DarkMagenta).Tampil();

            new Tulisan().SetXY(19, 7).SetLength(8).SetText("███████████").SetBackColor(ConsoleColor.Gray).SetForeColor(ConsoleColor.DarkMagenta).Tampil();
            new Tulisan().SetXY(19, 8).SetLength(8).SetText("█▀▄▄▀█▀▄▄▀█").SetBackColor(ConsoleColor.Gray).SetForeColor(ConsoleColor.DarkMagenta).Tampil();
            new Tulisan().SetXY(19, 9).SetLength(8).SetText("█▀▄▄▀█▀▄▄▀█").SetBackColor(ConsoleColor.Gray).SetForeColor(ConsoleColor.DarkMagenta).Tampil();
            new Tulisan().SetXY(19, 10).SetLength(8).SetText("█▀▄▄▀█▀▄▄▀█").SetBackColor(ConsoleColor.Gray).SetForeColor(ConsoleColor.DarkMagenta).Tampil();
            new Tulisan().SetXY(19, 11).SetLength(8).SetText("█▀▄▄▀█▀▄▄▀█").SetBackColor(ConsoleColor.Gray).SetForeColor(ConsoleColor.DarkMagenta).Tampil();
            new Tulisan().SetXY(19, 12).SetLength(8).SetText("█▀▄▄▀█▀▄▄▀█").SetBackColor(ConsoleColor.Gray).SetForeColor(ConsoleColor.DarkMagenta).Tampil();
            new Tulisan().SetXY(19, 13).SetLength(8).SetText("█▀▄▄▀█▀▄▄▀█").SetBackColor(ConsoleColor.Gray).SetForeColor(ConsoleColor.DarkMagenta).Tampil();
            new Tulisan().SetXY(19, 14).SetLength(8).SetText("█▀▄▄▀█▀▄▄▀█").SetBackColor(ConsoleColor.Gray).SetForeColor(ConsoleColor.DarkMagenta).Tampil();
            new Tulisan().SetXY(19, 15).SetLength(8).SetText("█▀▄▄▀█▀▄▄▀█").SetBackColor(ConsoleColor.Gray).SetForeColor(ConsoleColor.DarkMagenta).Tampil();
            new Tulisan().SetXY(19, 16).SetLength(8).SetText("█▀▄▄▀█▀▄▄▀█").SetBackColor(ConsoleColor.Gray).SetForeColor(ConsoleColor.DarkMagenta).Tampil();
            new Tulisan().SetXY(19, 17).SetLength(8).SetText("█▀▄▄▀█▀▄▄▀█").SetBackColor(ConsoleColor.Gray).SetForeColor(ConsoleColor.DarkMagenta).Tampil();
            new Tulisan().SetXY(19, 18).SetLength(8).SetText("█▀▄▄▀█▀▄▄▀█").SetBackColor(ConsoleColor.Gray).SetForeColor(ConsoleColor.DarkMagenta).Tampil();
            new Tulisan().SetXY(19, 19).SetLength(8).SetText("█▀▄▄▀█▀▄▄▀█").SetBackColor(ConsoleColor.Gray).SetForeColor(ConsoleColor.DarkMagenta).Tampil();
            new Tulisan().SetXY(19, 20).SetLength(8).SetText("█▀▄▄▀█▀▄▄▀█").SetBackColor(ConsoleColor.Gray).SetForeColor(ConsoleColor.DarkMagenta).Tampil();
            new Tulisan().SetXY(19, 21).SetLength(8).SetText("█▀▄▄▀█▀▄▄▀█").SetBackColor(ConsoleColor.Gray).SetForeColor(ConsoleColor.DarkMagenta).Tampil();
            new Tulisan().SetXY(19, 22).SetLength(8).SetText("█▀▄▄▀█▀▄▄▀█").SetBackColor(ConsoleColor.Gray).SetForeColor(ConsoleColor.DarkMagenta).Tampil();
            new Tulisan().SetXY(19, 23).SetLength(8).SetText("███████████").SetBackColor(ConsoleColor.Gray).SetForeColor(ConsoleColor.DarkMagenta).Tampil();
            new Tulisan().SetXY(19, 24).SetLength(8).SetText("").SetBackColor(ConsoleColor.Gray).SetForeColor(ConsoleColor.DarkGreen).Tampil();
            


            new Tulisan().SetXY(67, 1)/*.SetLength(110)*/.SetText("          APLIKASI BEL SEKOLAH           ").SetForeColor(ConsoleColor.DarkMagenta).SetBackColor(ConsoleColor.Gray).Tampil();
            new Tulisan().SetXY(110, 1).SetLength(8).SetText("█░█    ▄█").SetForeColor(ConsoleColor.DarkMagenta).SetBackColor(ConsoleColor.Gray).TampilTengah();
            new Tulisan().SetXY(110, 2).SetLength(8).SetText("▀▄▀  ▄ ░█").SetForeColor(ConsoleColor.DarkMagenta).SetBackColor(ConsoleColor.Gray).TampilTengah();
            new Tulisan().SetXY(110, 3).SetText("═════════").SetBackColor(ConsoleColor.Gray).SetForeColor(ConsoleColor.DarkMagenta).Tampil();
            new Tulisan().SetXY(67, 2)/*.SetLength(110)*/.SetText("        WEARNES EDUCATION CENTER         ").SetBackColor(ConsoleColor.Gray).SetForeColor(ConsoleColor.DarkMagenta)/*.SetBackColor(ConsoleColor.DarkRed)*/.Tampil();
            new Tulisan().SetXY(67, 3)/*.SetLength(110)*/.SetText("       JL.Thamrin 35A KOTA MADIUN        ").SetBackColor(ConsoleColor.Gray).SetForeColor(ConsoleColor.DarkMagenta)/*.SetBackColor(ConsoleColor.DarkGray)*/.Tampil();
            new Tulisan().SetXY(67, 4)/*.SetLength(110)*/.SetText("                                         ").SetBackColor(ConsoleColor.Gray).SetForeColor(ConsoleColor.DarkMagenta)/*.SetBackColor(ConsoleColor.DarkGray)*/.Tampil();
            //new Tulisan().SetXY(0, 26).SetLength(110).SetText("ALVIAN WAHYU DEWANTA").SetForeColor(ConsoleColor.DarkMagenta).SetBackColor(ConsoleColor.Gray).TampilTengah();
            //new Tulisan().SetXY(0, 27).SetLength(110).SetText("INFORMATIKA II - Bestfal").SetForeColor(ConsoleColor.DarkMagenta).SetBackColor(ConsoleColor.Gray).TampilTengah();

            Menu menu = new Menu("JALANKAN", "LIHAT DATA", "TAMBAH DATA", "EDIT DATA", "HAPUS DATA", "KELUAR");
            menu.SetXY(5, 10).SetForeColor(ConsoleColor.DarkMagenta).SetSelectedForeColor(ConsoleColor.Black).SetSelectedBackColor(ConsoleColor.DarkGray).SetBackColor(ConsoleColor.Gray).Tampil();

            for (int a = 1; a <= 24; a++)
            {
                Console.SetCursorPosition(111, 3 + a);
                Console.BackgroundColor = ConsoleColor.DarkMagenta;
                Console.Write(" ");
                Thread.Sleep(50);
            }



            for (int a = 1; a <= 24; a++)
            {
                Console.SetCursorPosition(113, 3 + a);
                Console.BackgroundColor = ConsoleColor.DarkMagenta;
                Console.Write(" ");
                Thread.Sleep(50);

            }
            for (int a = 1; a <= 24; a++)
            {
                Console.SetCursorPosition(115, 3 + a);
                Console.BackgroundColor = ConsoleColor.DarkMagenta;
                Console.Write(" ");
                Thread.Sleep(50);

            }
            for (int a = 1; a <= 24; a++)
            {
                Console.SetCursorPosition(117, 3 + a);
                Console.BackgroundColor = ConsoleColor.DarkMagenta;
                Console.Write(" ");
                Thread.Sleep(50);

            }
            logo();
            bool programjalan = true;

            while (programjalan)
            {
                ConsoleKeyInfo Tombol = Console.ReadKey(true);
                if (Tombol.Key == ConsoleKey.DownArrow)
                {
                    menu.Next();
                    menu.Tampil();

                }
                else if (Tombol.Key == ConsoleKey.UpArrow)
                {
                    menu.Prev();
                    menu.Tampil();
                }
                else if (Tombol.Key == ConsoleKey.Enter)
                {
                    int MenuTerpilih = menu.SelectedIndex;
                    if (MenuTerpilih == 0)
                    {
                        Jalankan();
                    }
                    if (MenuTerpilih == 1)
                    {
                        Lihatdata();
                    }
                    if (MenuTerpilih == 2)
                    {
                        Tambahdata();
                    }
                    if (MenuTerpilih == 3)
                    {
                        Editdata();
                    }
                    if (MenuTerpilih == 4)
                    {
                        Hapusdata();
                    }
                    if (MenuTerpilih == 5)
                    {
                        programjalan = false;
                    }
                    

               
                }

            }


































            Console.ReadKey();
        }
        static void Jalankan()
        {
            new Clear(32, 7, 76, 16).SetBackColor(ConsoleColor.Gray).Tampil();

            new Tulisan().SetXY(31, 7).SetText(".:JALANKAN:.").SetLength(79).SetForeColor(ConsoleColor.DarkMagenta).SetBackColor(ConsoleColor.Gray).TampilTengah();

            Tulisan HariSekarang = new Tulisan().SetXY(33, 9);
            Tulisan JamSekarang = new Tulisan().SetXY(33, 10);

            string Qselect = "SELECT * FROM tb_jadwal WHERE hari=@hari AND jam=@jam;";

            DB.Connect();

            bool Play = true;

            while(Play)
            {
                DateTime Sekarang = DateTime.Now;

                HariSekarang.SetText("HARI SEKARANG : " + Sekarang.ToString("dddd"));
                HariSekarang.SetForeColor(ConsoleColor.DarkMagenta).SetBackColor(ConsoleColor.Gray).Tampil();
                JamSekarang.SetText("JAM SEKARANG : " + Sekarang.ToString("HH:mm:ss"));
                JamSekarang.SetForeColor(ConsoleColor.DarkMagenta).SetBackColor(ConsoleColor.Gray).Tampil();

                DataTable DT = DB.RunQuery(Qselect,
                    new OleDbParameter("@hari", Sekarang.ToString("dddd")),
                    new OleDbParameter("@jam", Sekarang.ToString("HH:mm")));

                if(DT.Rows.Count >0)
                {
                    Audio HAAA = new Audio();
                    HAAA.File = "./Suara/" + DT.Rows[0]["sound"];
                    HAAA.Play();

                    new Tulisan().SetXY(31, 14).SetText("BEL TELAH BERBUNYI!!!").SetBackColor(ConsoleColor.DarkGreen).SetLength(79).TampilTengah();
                    new Tulisan().SetXY(31, 15).SetText(DT.Rows[0]["ket"].ToString()).SetBackColor(ConsoleColor.DarkGreen).SetLength(79).TampilTengah();

                    Play = false;
                }
                Thread.Sleep(1000);
                if (Console.KeyAvailable == true)
                {
                    ConsoleKeyInfo Tombol = Console.ReadKey(true);
                    if (Tombol.Key == ConsoleKey.End)
                    {
                        Play = false;
                        new Clear(32, 7, 76, 16).SetBackColor(ConsoleColor.Gray).Tampil();
                        logo();
                    }
                }
            }


        }
        static void Lihatdata()
        {
            new Clear(32, 7, 76, 16).SetBackColor(ConsoleColor.Gray).Tampil();

            new Tulisan().SetXY(31, 7).SetText(".:LIHAT DATA JADWAL:.").SetLength(79).SetForeColor(ConsoleColor.DarkMagenta).SetBackColor(ConsoleColor.Gray).TampilTengah();

            DB.Connect();
            DataTable DT = DB.RunQuery("SELECT * FROM tb_jadwal;");

            new Tulisan("┌────┬──────────┬───────┬────────────────────────────────────────┐").SetXY(34, 10).SetForeColor(ConsoleColor.DarkMagenta).SetBackColor(ConsoleColor.Gray).Tampil();
            new Tulisan("│ NO │   HARI   │  JAM  │             KETERANGAN                 │").SetXY(34, 11).SetForeColor(ConsoleColor.DarkMagenta).SetBackColor(ConsoleColor.Gray).Tampil();
            new Tulisan("├────┼──────────┼───────┼────────────────────────────────────────┤").SetXY(34, 12).SetForeColor(ConsoleColor.DarkMagenta).SetBackColor(ConsoleColor.Gray).Tampil();

            for(int i = 0; i < DT.Rows.Count;i++)
            {
                string ID = DT.Rows[i]["id"].ToString();
                string Hari = DT.Rows[i]["hari"].ToString();
                string Jam = DT.Rows[i]["jam"].ToString();
                string Keterangan = DT.Rows[i]["ket"].ToString();
                //string Sound = DT.Rows[i]["sound"].ToString();

                string isi = string.Format("|{0,-4}|{1,-10}|{2,-7}|{3,-40}|",ID,Hari,Jam,Keterangan);
                new Tulisan(isi).SetXY(34, 13 + i).SetForeColor(ConsoleColor.DarkMagenta).SetBackColor(ConsoleColor.Gray).Tampil();

            }


            new Tulisan("└────┴──────────┴───────┴────────────────────────────────────────┘").SetXY(34, 13 + DT.Rows.Count).SetForeColor(ConsoleColor.DarkMagenta).SetBackColor(ConsoleColor.Gray).Tampil();
        }
        static void Tambahdata()
        {
            new Clear(32, 7, 76, 16).SetBackColor(ConsoleColor.Gray).Tampil();

            new Tulisan().SetXY(31, 7).SetText(".:TAMBAH DATA JADWAL:.").SetLength(79).SetForeColor(ConsoleColor.DarkMagenta).SetBackColor(ConsoleColor.Gray).TampilTengah();

            Inputan HariInput = new Inputan();
            HariInput.Text = "Masukkan Hari : ";
            HariInput.SetXY(33, 9).SetForeColor(ConsoleColor.DarkMagenta).SetBackColor(ConsoleColor.Gray);

            Inputan JamInput = new Inputan();
            JamInput.Text = "Masukkan Jam : ";
            JamInput.SetXY(33, 10).SetForeColor(ConsoleColor.DarkMagenta).SetBackColor(ConsoleColor.Gray);

            Inputan KetInput = new Inputan();
            KetInput.Text = "Masukkan Keterangan : ";
            KetInput.SetXY(33, 11).SetForeColor(ConsoleColor.DarkMagenta).SetBackColor(ConsoleColor.Gray);

            //Inputan SoundInput = new Inputan();
            //SoundInput.Text = "Masukkan Sound : ";
            //SoundInput.SetXY(33, 12);
            Pilihan SoundInput = new Pilihan();
            SoundInput.SetPilihans(
                "Pelajaran ke 1.wav",
                "Pelajaran ke 2.wav",
                "Pelajaran ke 3.wav",
                "Pelajaran ke 4.wav",
                "Pelajaran ke 5.wav",
                "Pelajaran ke 6.wav",
                "Pelajaran ke 7.wav",
                "Akhir Pekan 1.wav",
                "Akhir Pekan 2.wav",
                "Pembuka.wav");

            SoundInput.Text = "Masukan Audio : ";
            SoundInput.SetXY(33, 12).SetForeColor(ConsoleColor.DarkMagenta).SetBackColor(ConsoleColor.Gray);




            string Hari = HariInput.Read();
            string Jam = JamInput.Read();
            string Ket = KetInput.Read();
            string Sound = SoundInput.Read();

            DB.Connect();
            DB.RunNonQuery("INSERT INTO tb_jadwal (hari, jam, ket, sound) VALUES (@hari, @jam, @ket, @sound);",
                new OleDbParameter("@hari", Hari),
                new OleDbParameter("@jam", Jam),
                new OleDbParameter("@ket", Ket),
                new OleDbParameter("@sound", Sound));
            DB.Disconnect();

            new Tulisan().SetXY(31, 14).SetText("DATA TELAH BERHASIL DISIMPAN!!!").SetBackColor(ConsoleColor.DarkGreen).SetLength(79).TampilTengah();


        }
        static void Editdata()
        {
            new Clear(32, 7, 76, 16).SetBackColor(ConsoleColor.Gray).Tampil();

            new Tulisan().SetXY(31, 7).SetText(".:EDIT DATA JADWAL:.").SetLength(79).SetForeColor(ConsoleColor.DarkMagenta).SetBackColor(ConsoleColor.Gray).TampilTengah();

            Inputan IDInputDirubah = new Inputan();
            IDInputDirubah.Text = "Masukkan ID : ";
            IDInputDirubah.SetXY(33, 10).SetForeColor(ConsoleColor.DarkMagenta).SetBackColor(ConsoleColor.Gray);

            Inputan HariInput = new Inputan();
            HariInput.Text = "Masukkan Hari : ";
            HariInput.SetXY(33, 11).SetForeColor(ConsoleColor.DarkMagenta).SetBackColor(ConsoleColor.Gray);


            Inputan JamInput = new Inputan();
            JamInput.Text = "Masukkan Jam : ";
            JamInput.SetXY(33, 12).SetForeColor(ConsoleColor.DarkMagenta).SetBackColor(ConsoleColor.Gray);

            Inputan KetInput = new Inputan();
            KetInput.Text = "Masukkan Keterangan : ";
            KetInput.SetXY(33, 13).SetForeColor(ConsoleColor.DarkMagenta).SetBackColor(ConsoleColor.Gray);

            //Inputan SoundInput = new Inputan();
            //SoundInput.Text = "Masukkan Sound : ";
            //SoundInput.SetXY(33, 12);

            Pilihan SoundInput = new Pilihan();
            SoundInput.SetPilihans(
                "Pelajaran ke 1.wav",
                "Pelajaran ke 2.wav",
                "Pelajaran ke 3.wav",
                "Pelajaran ke 4.wav",
                "Pelajaran ke 5.wav",
                "Pelajaran ke 6.wav",
                "Pelajaran ke 7.wav",
                "Akhir Pekan 1.wav",
                "Akhir Pekan 2.wav",
                "Pembuka.wav");

            SoundInput.Text = "Masukan Audio : ";
            SoundInput.SetXY(33, 14).SetForeColor(ConsoleColor.DarkMagenta).SetBackColor(ConsoleColor.Gray);

            string IDrubah = IDInputDirubah.Read();
            string Hari = HariInput.Read();
            string Jam = JamInput.Read();
            string Ket = KetInput.Read();
            string Sound = SoundInput.Read();

            DB.Connect();
            DB.RunNonQuery("UPDATE tb_jadwal SET hari=@hari, jam=@jam, ket=@ket, sound=@sound  WHERE id=@id;",
                new OleDbParameter("@hari", Hari),
                new OleDbParameter("@jam", Jam),
                new OleDbParameter("@ket", Ket),
                new OleDbParameter("@sound", Sound),
                new OleDbParameter("@id", IDrubah)
                );
            DB.Disconnect();

            new Tulisan().SetXY(31, 14).SetText("DATA TELAH BERHASIL DIUPDATE!!!").SetBackColor(ConsoleColor.DarkGreen).SetLength(79).TampilTengah();


        }
        static void Hapusdata()
        {
            new Clear(32, 7, 76, 16).SetBackColor(ConsoleColor.Gray).Tampil();

            new Tulisan().SetXY(31, 7).SetText(".:HAPUS DATA JADWAL:.").SetLength(79).SetForeColor(ConsoleColor.DarkMagenta).SetBackColor(ConsoleColor.Gray).TampilTengah();

            Inputan IDInput = new Inputan();
            IDInput.Text = "Masukan ID Yang Akan Dihapus : ";
            IDInput.SetXY(33, 9).SetForeColor(ConsoleColor.DarkMagenta).SetBackColor(ConsoleColor.Gray);
            string ID = IDInput.Read();

            DB.Connect();
            DB.RunNonQuery("DELETE FROM tb_jadwal WHERE id=" + ID + ";");

            new Tulisan().SetXY(31, 12).SetText("Data Berhasil Di HAPUS!!!").SetBackColor(ConsoleColor.DarkGreen).SetLength(79).TampilTengah();
        }
        static void logo()
        {

            new Tulisan("%@@-.*@@:.+@@+.................................................").SetXY(31, 11).SetLength(79).SetBackColor(ConsoleColor.Gray).SetForeColor(ConsoleColor.DarkMagenta).TampilTengah();
            new Tulisan("=@@*-%@@*.@@#:.#@@@%=..=@@@@@*.:@@#%#=%@*#@@#:..%@@@#-..-@@@@#:").SetXY(31, 12).SetLength(79).SetBackColor(ConsoleColor.Gray).SetForeColor(ConsoleColor.Black).TampilTengah();
            new Tulisan(".@@%=@@@@-@@*-%@#.:@@=.*##.-@@=-@@@@#=%@@**@@+-@@#.-%@=:@@*.-=-").SetXY(31, 13).SetLength(79).SetBackColor(ConsoleColor.Gray).SetForeColor(ConsoleColor.DarkMagenta).TampilTengah();
            new Tulisan("-*@@@@+#@@@%:+@@@@@@@%:*@@@@@@=-@@#..:%@#.:@@**@@@@@@@@.+@@@@@#").SetXY(31, 14).SetLength(79).SetBackColor(ConsoleColor.Gray).SetForeColor(ConsoleColor.Black).TampilTengah();
            new Tulisan(".:@@@#-*@@@#.:#@@:-@@=#@@-.=@@=-@@#..:%@#.:@@*-@@%-+@@=-@@*.*@@").SetXY(31, 15).SetLength(79).SetBackColor(ConsoleColor.Gray).SetForeColor(ConsoleColor.DarkMagenta).TampilTengah();
            new Tulisan("..#%%+.-%%%-...-%%%#-..#%%%+%%+-%%#..:#%#.:%%+..-%%%*:..:#%%%*.").SetXY(31, 16).SetLength(79).SetBackColor(ConsoleColor.Gray).SetForeColor(ConsoleColor.Black).TampilTengah();

        }
        
        

        

    }

    
}

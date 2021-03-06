﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tugas_Pertemuan_11.ClassAnak;
using Tugas_Pertemuan_11.ClassInduk;

namespace Tugas_Pertemuan_11
{
    class Program
    {
        static void Main(string[] args)
        {
            KaryawanTetap karyawantetap = new KaryawanTetap();
            karyawantetap.Nik = "123-3221-245";
            karyawantetap.Nama = "Dono Suyama";
            karyawantetap.GajiBulanan = 5000000;

            KaryawanHarian karyawanharian = new KaryawanHarian();
            karyawanharian.Nik = "19-11-2863";
            karyawanharian.Nama = "Kevin Callahan";
            karyawanharian.JumlahJamKerja = 12;
            karyawanharian.UpahPerJam = 150000;

            Sales seles = new Sales();
            seles.Nik = "123-0804-202";
            seles.Nama = "Farel Fuller";
            seles.JumlahPenjualan = 12;
            seles.Komisi = 500000;

            List<Karyawan> listkaryawan = new List<Karyawan>();

            listkaryawan.Add(karyawantetap);
            listkaryawan.Add(karyawanharian);
            listkaryawan.Add(seles);

            int no = 1;
            foreach (Karyawan karyawan in listkaryawan)
            {
                Console.WriteLine("{0}. Nik: {1}, Nama: {2}, Gaji: {3}",
                no, karyawan.Nik, karyawan.Nama, karyawan.gaji());
                no++;
            }
            Console.ReadKey();
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Model
{
    public class Barang
    {
        public string NamaBarang { get; set; }

        public int KodeBarang { get; set; }

        public int JumlahBarang { get; set; }

        public int HargaBarang { get; set; }

        public Barang(string NamaBarang, int KodeBarang, int JumlahBarang, int HargaBarang)
        {
            this.NamaBarang = NamaBarang;
            this.KodeBarang = KodeBarang;
            this.JumlahBarang = JumlahBarang;
            this.HargaBarang = HargaBarang;
        }

        internal static void Add(Barang barang)
        {
            throw new NotImplementedException();
        }

        internal static void RemoveAt(int id)
        {
            throw new NotImplementedException();
        }
    }
}


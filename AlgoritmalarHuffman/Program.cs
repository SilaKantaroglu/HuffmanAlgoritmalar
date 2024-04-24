using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmalarHuffman
{
    class Program
    { /*class Btree
        {
            public int data;
            public int ch;
            public string huffman;
            public Btree left;
            public Btree right;

        }
        // b1 c1 d1 a3
        // en düşük frekanslı iki tanesi birleşecek 
        static Btree local(Btree a , Btree b)
        {
            Btree bt = new Btree();
            bt.data = a.data + b.data;
            bt.left = a;
            bt.right = b;
            return bt;
        }
        static void tree(Btree[] bt)
        {
            if (bt[1] == null) return;
            bt[0] = local(bt[0] , bt[1]);
            bt[1] = null;

            Array.Sort(bt, (object x, object y) => {
                int a = 0;
                if (x == null && y == null) return 0;
                if (x == null) return 1;
                if (y == null) return -1;
                if (((Btree)x).data < ((Btree)y).data)a = -1;
                if (((Btree)x).data > ((Btree)y).data)a = 1;
                return a;

            });
            tree(bt);
        }
        // tree yi dolaştık
        static void yazBtree(Btree bt , string yon)
        {
            if (bt == null) return;
            if (bt.left == null) bt.huffman = yon;
            yazBtree(bt.left, yon + "0");
          if (bt.right == null) bt.huffman = yon;
            yazBtree(bt.right, yon + "1");
        }
        static void yazBtreeSonuc(Btree bt)
        {
            if (bt == null) return;
            if (bt.left == null) Console.WriteLine("{0}     {1}", (char)bt.ch, bt.huffman);
            yazBtreeSonuc(bt.left);
            yazBtreeSonuc(bt.right);
        }
        static void Main(string[] args)
        {
            Btree[] bt1 = new Btree[10];
            for (int i = 0; i < 10; i++)
            {
                bt1[i] = new Btree();
                bt1[i].data = i + 1;
                bt1[i].ch = (byte)'A' + i;
                // A, B, C, D, E, F, G, H, I, J 
            }
            tree(bt1);
            yazBtree(bt1[0], "");
            yazBtreeSonuc(bt1[0]);
            
        }*/
        static uint hesapla(uint a, uint sonuc, int adet)
        {
            if (adet == 0) return sonuc;
            sonuc = sonuc << 1;
            if ((a & 0x80000000) == 0) sonuc++;
            a = a << 1;
            return hesapla(a, sonuc, adet - 1);
        }
        static void Main(string[] args)
        {
            hesapla(1210, 1, 32);
        }
    }
}

using System;
using System.Globalization;
using System.Collections.Generic;
namespace THI
{
    class Program
    {
        static void Main(string[]args)
        {
            
            List<Idol>IDOL=new List<Idol>
            {
                new Idol("A",35,14,89,29),
                new Idol("B",66,22,13,93),
                new Idol("C",10,19,18,41),
                new Idol("D",11,5,63,8),
                new Idol("E",3,2,9,13),
                new Idol("Y",27,14,0,36),
                new Idol("H",74,8,3,31),
            };

            List<Debut>DEBUT=new List<Debut>
            {
                new Debut("A",15,41,49),
                new Debut("B",36,23,63),
                new Debut("C",10,19,28),
           
            };

            List<Intern>INTERN=new List<Intern>
            {
                new Intern("A",85,14),
                new Intern("B",16,42),
                new Intern("C",10,19),
                new Intern("D",11,55),
                new Intern("E",13,82),
          
            };

        Console.WriteLine("THONG TIN NGHE SI IDOL:");
        foreach(var k in IDOL)
        {
            k.Luong();
            k.xuat();
        }
         Console.WriteLine("---------------------------------");
          Console.WriteLine("THONG TIN NGHE SI DEBUT:");
         foreach(var m in DEBUT)
        {
            m.Luong();
            m.xuat();
        }
          Console.WriteLine("---------------------------------");
          Console.WriteLine("THONG TIN NGHE SI INTERN:");
         foreach(var l in INTERN)
        {
            l.Luong();
            l.xuat();
        }
       

        }
    }
    abstract class NGHESI
    {
        public string tennghesi;
        public int sonamlamviec,soluongtrinhdien;
        public double luong,kpi;
        public abstract void Luong();
        public NGHESI(string tennghesi,int sonamlamviec,int soluongtrinhdien)
        {
            this.tennghesi=tennghesi;
            this.sonamlamviec=sonamlamviec;
            this.soluongtrinhdien=soluongtrinhdien;
        }
        public virtual void xuat()
        {
            Console.Write($"TEN NGHE SI:{tennghesi}, SO NAM LAM VIEC:{sonamlamviec}, SO LUONG TRINH DIEN:{soluongtrinhdien}");
        }
        
    }
    class Idol:NGHESI
    {
        public int soluongsukien,soluonggameshow;
        public Idol(string tennghesi,int sonamlamviec,int soluongtrinhdien,int soluongsukien,int soluonggameshow):base(tennghesi,sonamlamviec,soluongtrinhdien)
        {
            this.soluongsukien=soluongsukien;
            this.soluonggameshow=soluonggameshow;
        }
        public override void Luong()
        {
            if(soluongtrinhdien>=15 & (soluongsukien+soluonggameshow)>=10)
            {
                kpi=0.3*(500*soluongtrinhdien+200*soluongsukien+300*soluonggameshow);
            }
            else{
                kpi=0;
            }
            luong=1000+100*sonamlamviec+500*soluongtrinhdien+200*soluongsukien+300*soluonggameshow+kpi;
        }
        public override void xuat()
        {
            base.xuat();
            Console.WriteLine($", SO LUONG SU KIEN:{soluongsukien}, SO LUONG GAMESHOW:{soluonggameshow}, KPI:{kpi}, LUONG:{luong}");

        }
    }
    class Debut:NGHESI
    {
        public int soluongsukien;
        public Debut(string tennghesi,int sonamlamviec,int soluongtrinhdien,int soluongsukien):base(tennghesi,sonamlamviec,soluongtrinhdien)
        {
            this.soluongsukien=soluongsukien;
            
        }
        public override void Luong()
        {
            if(soluongtrinhdien>=20 & soluongsukien>=10)
            {
                kpi=0.15*(300*soluongtrinhdien+100*soluongsukien);
            }
            else{
                kpi=0;
            }
            luong=500+50*sonamlamviec+300*soluongtrinhdien+100*soluongsukien+kpi;
        }
        public override void xuat()
        {
            base.xuat();
            Console.WriteLine($", SO LUONG SU KIEN:{soluongsukien}, KPI:{kpi}, LUONG:{luong}");

        }
    }
    class Intern:NGHESI
    {
        public Intern(string tennghesi,int sonamlamviec,int soluongtrinhdien):base(tennghesi,sonamlamviec,soluongtrinhdien)
        {
            
        }
        public override void Luong()
        {
            if(soluongtrinhdien>=20)
            {
                kpi=0.1*200*soluongtrinhdien;
            }
            else{
                kpi=0;
            }
            luong=300+50*sonamlamviec+200*soluongtrinhdien+kpi;
        }
        public override void xuat()
        {
            base.xuat();
            Console.WriteLine($", KPI:{kpi}, LUONG:{luong}");

        }
    }
   
}
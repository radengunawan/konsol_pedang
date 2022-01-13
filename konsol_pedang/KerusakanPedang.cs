using System;
using System.Collections.Generic;
using System.Text;

namespace konsol_pedang
{
    class KerusakanPedang
    {
        public const int LUKA_DASAR = 3;
        public const int LUKA_BAKAR = 2;

        public int Roll;
        public decimal PengaliAjaib = 1M;
        public int RusakTerbakar = 0;
        public int Kerusakan;

        public void HitungKerusakan()
        {
            Kerusakan = (int)(Roll * PengaliAjaib) + LUKA_DASAR + RusakTerbakar;

        }

        public void AturKeajaiban(bool Keajaiban)
        {
            if (Keajaiban)
            {
                PengaliAjaib = 1.75M;
            }
            else
            {
                PengaliAjaib = 1M;
            }
            HitungKerusakan();
        }

        public void AturNyalaApi(bool Nyala)
        {
            HitungKerusakan();
            if (Nyala)
            {
                Kerusakan += LUKA_BAKAR;
            }
        }


    }
}

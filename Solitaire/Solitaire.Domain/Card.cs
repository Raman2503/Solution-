﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solitaire.Domain
{
    public class Card
    {
        public Rank Rank { get; set; }
        public Suit Suit { get; set; }

        public Card(Rank pRank, Suit pSuit)
        {
            Rank = pRank;
            Suit = pSuit;
        }

        public override string ToString()
        {
            return string.Format("{0} {1}",Rank,Suit);
        }
    }
}
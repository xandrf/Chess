﻿namespace tabuleiro {   
    class Posicao{
        public int Linha { get; set; }
        public int Coluna { get; set; }


        public Posicao(int Linha,int Coluna){
            this.Coluna = Coluna;
            this.Linha = Linha;
        }
        public override string ToString()
        {
            return Linha
                +","
                +Coluna;
        }

    }
}
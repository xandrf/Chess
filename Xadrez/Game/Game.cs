﻿using System;
using tabuleiro;

namespace Xadrez {
    abstract class Game {
        public abstract void GameLoop();
        public abstract void montarTela();
    }
}

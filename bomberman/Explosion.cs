﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace bomberman
{
    internal class Explosion    //爆炸
    {
        public const int ExplosionHeight = 70, ExplosionWidth = 70;
        public PictureBox boxExplosion = new PictureBox();

        public Explosion()
        {
            this.boxExplosion.Size = new Size(ExplosionHeight, ExplosionWidth); //設定爆炸大小
            this.boxExplosion.Image = Properties.Resources.explosion;           //設定爆炸圖案
            this.boxExplosion.Tag = "explosion";
        }

        //生成
        public void Spawn(int posX, int posY)
        {
            this.boxExplosion.Location = new Point(posX, posY); //移動爆炸到生成位置
        }
    }
}

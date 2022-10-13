﻿using System;

namespace SpaceShooter_2020 {
    static class RandomGenerator {
        private static Random rand;

        static RandomGenerator() {
            rand = new Random();
        }

        public static int GetRandomInt(int min, int max) {
            return rand.Next(min, max);
        }

        public static float GetRandomFloat() {
            return (float)rand.NextDouble();
        }
    }
}

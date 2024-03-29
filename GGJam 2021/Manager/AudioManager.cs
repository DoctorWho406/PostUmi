﻿using System;
using System.Collections.Generic;
using Aiv.Audio;

namespace GGJam_2021 {
    static class AudioManager {
        private static Dictionary<string, AudioClip> audioclips;
        private static Random random;
        public static string[] RadioChannel;
        public static bool RadioOn;
        public static float DeltaTime => Game.DeltaTime;
        static AudioManager() {
            audioclips = new Dictionary<string, AudioClip>();
            random = new Random();
            RadioChannel = new string[3];
            RadioChannel[0] = "Radio01";
            RadioChannel[1] = "Radio02";
            RadioChannel[2] = "Radio03";
            RadioOn = false;

        }

        public static void AddClips(string key, string clipPath) {
            AudioClip a = new AudioClip(clipPath);
            audioclips[key] = a;
        }
        public static AudioClip GetAudioClip(string key) {
            AudioClip a = null;
            if (audioclips.ContainsKey(key)) {
                a = audioclips[key];
            }
            return a;
        }
        public static void Clear() {
            audioclips.Clear();
        }
        public static void FadeIn(AudioSource s, float volume, AudioClip a) {
            s.Stream(a, DeltaTime);
            if (volume < 1f) {
                //seconds = 1 -> FadeIn = 10seconds
                volume += Game.DeltaTime * (2 * 0.1f);
                s.Volume = volume;
            }
        }
        public static void FadeIn(AudioSource s, float volume) {

            if (volume < 1f) {
                //seconds = 1 -> FadeIn = 10seconds
                volume += Game.DeltaTime * (2 * 0.1f);
                s.Volume = volume;
            }
        }
        public static void FadeOut(AudioSource s, float volume, AudioClip a) {
            s.Stream(a, DeltaTime);
            if (volume > 0f) {
                volume -= Game.DeltaTime * (3 * 0.1f);
                s.Volume = volume;
            } else {
                s.Stop();
            }
        }
        public static void FadeOut(AudioSource s, float volume) {
            if (volume > 0f) {
                volume -= Game.DeltaTime * (3 * 0.1f);
                s.Volume = volume;
            } else {
                s.Stop();
            }
        }
        public static string Shuffle(string[] array, int max) {
            return array[random.Next(0, max)];
        }
        public static void Radio() {
            if (RadioOn == true) {
                MusicManager.RadioEmitter.Stream(MusicManager.RadioClip, Game.DeltaTime);
            } else {
                MusicManager.RadioEmitter.Stop();
            }
        }
    }
}


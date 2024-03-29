﻿using System.Collections.Generic;

namespace GGJam_2021 {
    static class PhysicsManager {
        static List<Rigidbody> items;

        static PhysicsManager() {
            items = new List<Rigidbody>();
        }

        public static void AddItem(Rigidbody rb) {
            items.Add(rb);
        }

        public static void RemoveItem(Rigidbody rb) {
            items.Remove(rb);
        }

        public static void Update() {
            for (int i = 0; i < items.Count; i++) {
                if (items[i].IsActive) {
                    items[i].Update();
                }
            }
        }

        public static void CheckCollisions() {
            for (int i = 0; i < items.Count - 1; i++) {
                if (items[i].IsActive && items[i].IsCollisionsAffected) {
                    //check collisions with next items
                    for (int j = i + 1; j < items.Count; j++) {
                        if (items[j].IsActive && items[j].IsCollisionsAffected) {
                            //check if one of the RB is interested in collision check

                            bool firstCheck = items[i].CollisionTypeMatches(items[j].Type);
                            bool secondCheck = items[j].CollisionTypeMatches(items[i].Type);

                            if ((firstCheck || secondCheck) && items[i].Collides(items[j])) {
                                if (firstCheck) {
                                    items[i].GameObject.OnCollide(items[j].GameObject);
                                }

                                if (secondCheck) {
                                    items[j].GameObject.OnCollide(items[i].GameObject);
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void ClearAll() {
            items.Clear();
        }
    }
}

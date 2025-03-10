﻿using Modding;
using UnityEngine;

namespace UnconstrainedRotation {
    public class UnconstrainedRotation: Mod {
        new public string GetName() => "UnconstrainedRotation";
        public override string GetVersion() => "1.0.2.0";

        public override void Initialize() {
            On.HeroController.Update10 += heroUpdate;
        }

        private void heroUpdate(On.HeroController.orig_Update10 orig, HeroController self) {
            orig(self);
            Rigidbody2D rb = self.gameObject.GetComponent<Rigidbody2D>();
            RigidbodyConstraints2D constraints = rb.constraints;
            rb.constraints = constraints & (RigidbodyConstraints2D.FreezePosition);

        }
    }
}
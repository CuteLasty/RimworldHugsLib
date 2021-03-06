﻿#if TEST_MOD
using HugsLib.Utils;
using Verse;

namespace HugsLib.Test {
	internal class TestUWO1 : UtilityWorldObject {
		private int testInt;
		
		public override void ExposeData() {
			base.ExposeData();
			Scribe_Values.Look(ref testInt, "testInt", 0);
		}
		
		public void UpdateAndReport() {
			testInt++;
			TestMod.Instance.Logger.Message(GetType().Name + " testInt:" + testInt);
		}
	}

	internal class TestUWO2 : UtilityWorldObject {
		private string testString = "";

		public override void ExposeData() {
			base.ExposeData();
			Scribe_Values.Look(ref testString, "testString", "");
		}

		public void UpdateAndReport() {
			testString += "+";
			TestMod.Instance.Logger.Message(GetType().Name + " testString:" + testString);
		}
	}
}
#endif
using System;

namespace KWDT.Core
{
	public static class TestState
	{
        public static object NewTest;
        public static object OrgTest;

		public static void SetTests(Object orgTest, Object newTest)
		{
			OrgTest = orgTest;
			NewTest = newTest;
		}

		public static bool TestUpdated()
		{
			return OrgTest == NewTest;
		}
	}
}

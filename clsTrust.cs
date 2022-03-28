using NBitcoin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BiblePayTrustGenerator
{
	public static class Trust
	{
		public static bool isShuttingDown = false;
		public static string msHODL = "";
		private static string base58_CHARS = "123456789ABCDEFGHJKLMNPQRSTUVWXYZabcdefghijkmnopqrstuvwxyz";
		public static string msWikiPage = "https://wiki.biblepay.org/Time_Locked_Trust";

		static Network net = Network.Main;
		public static ulong nTries = 0;
		public static long nSeconds = 0;
		public static string sPubKey = "";
		public static string sPrivKey = "";
		public static bool SearchForHODL(bool fTestNet, int nMM, int nYYYY)
		{
			sPubKey = "";
			sPrivKey = "";
			msHODL = "HD" + ConvertIntToBase58(nMM) + ConvertIntToBase58(nYYYY - 2020);
			int nThreadCount = 24;
			nSeconds = 0;
			isShuttingDown = false;
			net = fTestNet ? Network.TestNet : Network.Main;
			long nTS = IsHODLAddress(msHODL);
			DateTime dtMaturity = ConvertUnixTimeStampToDateTime(nTS);

			for (int i = 0; i < nThreadCount; i++)
			{
				Thread t0 = new Thread(GenerateAddresses);
				t0.Start();
			}

			while (!isShuttingDown)
			{
				System.Threading.Thread.Sleep(1000);
				nSeconds++;
				System.Windows.Forms.Application.DoEvents();
			}

			return true;
		}


		static void GenerateAddresses()
		{
			while (!isShuttingDown)
			{
				Key key1 = new Key();
				var secret = new BitcoinSecret(key1, net);
				string address = secret.GetAddress(ScriptPubKeyType.Legacy).ToString();
				bool fFound = address.Contains(msHODL);
				if (fFound)
				{
					isShuttingDown = true;
					sPrivKey = key1.GetWif(net).ToString();
					sPubKey = address;
					Console.Beep(444, 250);
					Console.Beep(625, 250);
					Console.Beep(777, 250);
					return;
				}
				nTries++;
			}
		}


		private static int ConvertBase58ToInt(string sInput)
		{
			for (int i = 0; i < base58_CHARS.Length; i++)
			{
				string sChar = base58_CHARS.Substring(i, 1);
				if (sInput == sChar)
					return i + 1;
			}
			return 0;
		}

		private static string ConvertIntToBase58(int nInput)
        {
			nInput = nInput - 1;
			if (nInput < 0 || nInput > 57)
				return "-";
			string sChar = base58_CHARS.Substring(nInput, 1);
			return sChar;
        }
		private static long ConvertDateToTimeStamp(int nMM, int nYY)
        {
			DateTime dt = new DateTime(nYY, nMM, 1);
			long ts = ((DateTimeOffset)dt).ToUnixTimeSeconds();
			return ts;
		}

		public static DateTime ConvertUnixTimeStampToDateTime(long ts)
        {
			DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
			dateTime = dateTime.AddSeconds(ts).ToLocalTime();
			return dateTime;
		}

		public static long IsHODLAddress(string sAddress)
		{
			// If this is not a HODL, return 0
			int nHODL = sAddress.IndexOf("HD");
			if (nHODL == -1)
				return 0;
			if (nHODL + 3 > sAddress.Length - 1)
				return 0;
			string sMM = sAddress.Substring(nHODL + 2, 1);
			string sYY = sAddress.Substring(nHODL + 3, 1);
			int nMM = ConvertBase58ToInt(sMM);
			int nYY = ConvertBase58ToInt(sYY) + 2020;
			if (nMM < 1 || nMM > 12)
				return 0;
			// This is a HODL wallet address, convert the timestamp to a unix timestamp (the MaturityDate)
			long nMaturityDate = ConvertDateToTimeStamp(nMM, nYY);
			return nMaturityDate;
		}

	}
}

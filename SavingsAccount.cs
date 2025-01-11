using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class SavingsAccount
    {
        public static double currentInterestRate;
        public static double bondRate;
        static SavingsAccount() {
            currentInterestRate = 0.4;
        }

        public static void AddBondRate() {
            currentInterestRate = bondRate + 0.1;
        }
    }
}
using System;

namespace Skat
{
    public class Afgift
    {
        
        
        /// <summary>
        /// Metode til at udregne afgiften på biler som ikke er elbiler.
        /// Metoden er delt op i to.
        /// En med biler med en pris til om med 200000
        /// og en med biler med en pris på over 200000
        /// </summary>
        /// <param name="pris"></param>
        /// <returns></returns>
        public int Bilafgift(int pris)
        {
            var bilAfgiftLav = Convert.ToInt32(pris * 0.85);
            var bilAfgiftHøj1 = Convert.ToInt32(pris * 1.5);
            var bilAfgiftHøj2 = bilAfgiftHøj1 - 130000;

            if (pris <= 200000)
            {
                return bilAfgiftLav;
            }
            else
            {
                return bilAfgiftHøj2;
            }
        }

        /// <summary>
        /// Metode til at udregne afgiften på elbiler.
        /// Metoden er delt op i to.
        /// En med elbiler der har en pris til og med 200000
        /// og en med elbiler der har en pris på mere end 200000
        /// </summary>
        /// <param name="pris"></param>
        /// <returns></returns>
        public int ElBilAfgift(int pris)
        {
            var bilAfgiftLav = Convert.ToInt32(pris * 0.85);
            var bilAfgiftHøj1 = Convert.ToInt32(pris * 1.5);
            var bilAfgiftHøj2 = bilAfgiftHøj1 - 130000;
            var elBilAfgiftLav = Convert.ToInt32(bilAfgiftLav * 0.2);
            var elBilAfgiftHøj = Convert.ToInt32(bilAfgiftHøj2 * 0.2);

            if (pris <= 200000)
            {
                return elBilAfgiftLav;
            }
            else
            {
                return elBilAfgiftHøj;
            }
        }

        
    }
}
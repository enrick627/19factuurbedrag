//Enrick De Munter 5ITN nr3 19/11/2019
/*OPGAVE
 * ======
 * Indien een klant betaalt binnen de 10 dagen na factuurdatum dan krijgt de klant 2 % financiële korting. Ontwerp een toepassing waarin de handelaar het bedrag exclusief BTW (21 %)
 * en het aantal dagen na factuurdatum waarop de factuur betaald is, ingeeft.
 *
 *De toepassing toont vervolgens:
 *
 *- het bedrag exclusief BTW;
 *- de eventuele financiële korting (in EUR);
 *- het bedrag exclusief BTW verminderd met de financiële korting;
 *- het BTW bedrag;
 *- het bedrag inclusief BTW.
 * 
 * ANALYSE
 * =======
 * VRAAG (het bedrag excl BTW )
 * VRAAG (het aantal dagen na factuurdatum waarop de factuur betaald is)
 * 
 * BEREKEN bedrag excl btw (het bedrag dat gegeven is door de persoon)
 * BEREKEN eventuele finan kort 
 *              ALS     aantaldagenbetaling <= 10
 *              DAN     financielekorting = bedragexclbtw * 2%
 *              ANDERS  financielekorting = 0
 * BEREKEN (bedrag excl btw - finan kort)
 * BEREKEN BTW bedrag (bedrag excl btw en finan kort /100*21)
 * BEREKEN bedrag incl btw ( bedrag excl btw + bedrag btw)
 * BEREKEN ANTWOORD
 * 
 * TOON het bedrag exclusief BTW;
 * TOON- de eventuele financiële korting (in EUR);
 * TOON- het bedrag exclusief BTW verminderd met de financiële korting;
 * TOON- het BTW bedrag;
 * TOON- het bedrag inclusief BTW
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factuurbedrag
{
    class Program
    {
        static void Main(string[] args)
        {
            //DECLARATIES
            decimal  bedragexclbtw;
            ushort aantaldagennafactgeldig, aantaldagennafact;
            string bedragexclbtwgeldig;


            //input
            //VRAAG(het bedrag excl BTW)
            Console.WriteLine("wat is uw bedrag excl BTW");
            bedragexclbtwgeldig = Console.ReadLine();
            // VRAAG(het aantal dagen na factuurdatum waarop de factuur betaald is)
            Console.WriteLine("wat is het aantal dagen na factuurdatum waarop de factuur betaald is?: ");
            aantaldagennafactgeldig = ushort.Parse(Console.ReadLine());
            //processing
            //BEREKEN bedrag excl btw(het bedrag dat gegeven is door de persoon)
            //BEREKEN eventuele finan kort(bedrag excl BTW / 100 * 21)
            //BEREKEN(bedrag excl btw - finan kort)
            //BEREKEN BTW bedrag(bedrag excl btw en finan kort / 100 * 21)
            //BEREKEN bedrag incl btw(bedrag excl btw + bedrag btw)

            //output
            //TOON het bedrag exclusief BTW;
            //TOON - de eventuele financiële korting(in EUR);
            //TOON - het bedrag exclusief BTW verminderd met de financiële korting;
            //TOON - het BTW bedrag;
            //TOON - het bedrag inclusief BTW


            //wachten
            Console.WriteLine();
            Console.WriteLine("druk op enter om af te sluiten!: ");
            Console.ReadKey();

        }
    }
}

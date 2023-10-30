using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static int[] ammo; // declaration
        static int currentWeapon;

        static void Main(string[] args)
        {
            Console.WriteLine("Arrays");
            Console.WriteLine("------");
            Console.WriteLine();

            //single weapon
            //weapon ammo amount
            //int ammo;
            //ammo = 0;
            // Fire()
            // Reload()
            // Range check (0...50)

            //multiple weapons
            // weapon ammo (for all weapons)
            // 0 - pistol
            // 1 - shotgun
            // 2 - spreader
            // 3 - rocket launcher

            //multiple weapons w/arrays
            
                        // "int[]" = type = "array of ints"

            ammo = new int[4]; // instantiation (NEW!) -- make sure there's memory! could fail!
            ammo[0] = 50; // pistol
            ammo[1] = 20; // shotgun
            ammo[2] = 100; // spreader
            ammo[3] = 6; // rocket launcher
                         // ammo[4] = 0; -- WILL NOT WORK

            
            currentWeapon = 0; // pistol

            // Fire(int currentWeapon);
            // 

            // PickUp(int weaponType)


            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey(true);

        }
        static void Fire()
        {
            if (ammo[currentWeapon] <= 0) return;

            ammo[currentWeapon] = ammo[currentWeapon] - 1;
            
        }
    }
}

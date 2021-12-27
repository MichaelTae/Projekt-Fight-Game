using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Fight_Game
{
    public class WeaponPattern
    {


        public void BuildStandardSword(IWeaponBuilder standardBuilder)
        {
           

            standardBuilder.setBlade("Common").setEnchantment("none").setHilt("standard").setPommel("round").setSize("Short Sword");

           
        }

        public void LegendarySword(IWeaponBuilder legendaryBuilder)
        {

            legendaryBuilder.setBlade("Legendary").setEnchantment("Fire").setHilt("Legendary").setPommel("Round").setSize("Great Sword");

        }

        public void ShortDagger(IWeaponBuilder shortDagger)
        {

            shortDagger.setBlade("Uncommon").setEnchantment("Life Steal").setHilt("Narrow Grip").setSize("Dagger");
        }

        public void ArtifactSpear(IWeaponBuilder artifactSpear)
        {

            artifactSpear.setBlade("Artifact").setEnchantment("Divine Shield").setSize("Spear");
        }



    }
}

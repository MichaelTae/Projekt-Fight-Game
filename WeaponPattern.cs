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
           

            standardBuilder.setBlade("Standard").setEnchantment("none").setHilt("standard").setPommel("round").setSize("standard");

           
        }


    }
}

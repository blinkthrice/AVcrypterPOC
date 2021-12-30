using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuackCrypt_DOTNET.Core
{
    public class Junk
    {
        public static List<string> Educks = new List<string>(new string[]{
            "African_Black_Duck", "African_Pygmy_Goose", "American_Black_Duck", "American_White_Winged_Scoter", "American_Wigeon", "Andean_Teal", "Asian_White_Winged_Scoter", "Auckland_Islands_Teal", "Australasian_Shoveler", "Australian_Shelduck", "Australian_Wood_Duck", "Baers_Pochard", "Baikal_Teal", "Barrows_Goldeneye", "Black_Scoter", "Black_Bellied_Whistling_duck", "Black_Headed_Duck", "Blue_Duck", "Blue_Billed_Duck", "Blue_Winged_Goose", "Blue_Winged_Teal", "Brazilian_Merganser", "Brazilian_Teal", "Brown_Teal", "Bufflehead", "Campbell_Islands_Teal", "Canvasback", "Cape_Shoveler", "Cape_Teal", "Chestnut_Teal", "Chiloe_Wigeon", "Cinnamon_Teal", "Comb_Duck", "Common_Eider", "Common_Goldeneye", "Common_Merganser", "Common_Pochard", "Common_Scoter", "Common_Shelduck", "Common_Teal", "Cotton_Pygmy_Goose", "Crested_Duck", "Crested_Shelduck", "Eastern_Spot_Billed_Duck", "Eatons_Pintail", "Egyptian_Goose", "Eurasian_Wigeon", "Falcated_Duck", "Falkland_Steamerduck", "Ferruginous_Duck", "Flightless_Steamerduck", "Flying_Steamerduck", "Freckled_Duck", "Fulvous_Whistling_Duck", "Gadwall", "Garganey", "Greater_Scaup", "Green_Pygmy_Goose", "Grey_Teal", "Hardhead", "Harlequin_Duck", "Hartlaubs_Duck", "Hawaiian_Duck", "Hooded_Merganser", "Hottentot_Teal", "Kelp_Goose", "King_Eider", "Lake_Duck", "Laysan_Duck", "Lesser_Scaup", "Lesser_Whistling_Duck", "Long_Tailed_Duck", "Maccoa_Duck", "Madagascar_Pochard", "Madagascar_Teal", "Mallard", "Mandarin_Duck", "Marbled_Teal", "Masked_Duck", "Mellers_Duck", "Mottled_Duck", "Muscovy_Duck", "Musk_Duck", "New_Zealand_Scaup", "Northern_Pintail", "Northern_Shoveler", "Orinoco_Goose", "Pacific_Black_Duck", "Paradise_Shelduck", "Philippine_Duck", "Pink_Eared_Duck", "Pink_Headed_Duck", "Plumed_Whistling_Duck", "Puna_Teal", "Radjah_Shelduck", "Red_Shoveler", "Red_Billed_Duck", "Red_Breasted_Merganser", "Red_Crested_Pochard", "Redhead", "Ring_Necked_Duck", "Ringed_Teal", "Rosy_Billed_Pochard", "Ruddy_Duck", "Ruddy_Shelduck", "Salvadoris_Teal", "Scaly_Sided_Merganser", "Silver_Teal", "Smew", "South_African_Shelduck", "Southern_Pochard", "Spectacled_Duck", "Spectacled_Eider", "Spotted_Whistling_Duck", "Stellers_Eider", "Sunda_Teal", "Surf_Scoter", "Torrent_Duck", "Tufted_Duck", "Velvet_Scoter", "Wandering_Whistling_Duck", "West_Indian_Whistling_Duck", "Western_Spot_Billed_Duck", "White_Backed_Duck", "White_Cheeked_Pintail", "White_Faced_Whistling_duck", "White_Headed_Duck", "White_Headed_Steamerduck", "White_Winged_Duck", "Wood_Duck", "Yellow_Billed_Duck", "Yellow_Billed_Pintail", "Yellow_Billed_Teal"
        });
        public static List<string> Lducks = new List<string>(new string[]{
            "Anas_sparsa", "Nettapus_auritus", "Anas_rubripes", "Melanitta_deglandi", "Anas_americana", "Anas_andium", "Melanitta_stejnegeri", "Anas_aucklandica", "Anas_rhynchotis", "Tadorna_tadornoides", "Chenonetta_jubata", "Aythya_baeri", "Anas_formosa", "Bucephala_islandica", "Melanitta_americana", "Dendrocygna_autumnalis", "Heteronetta_atricapilla", "Hymenolaimus_malacorhynchos", "Oxyura_australis", "Cyanochen_cyanoptera", "Anas_discors", "Mergus_octosetaceus", "Amazonetta_brasiliensis", "Anas_chlorotis", "Bucephala_albeola", "Anas_nesiotis", "Aythya_valisineria", "Anas_smithii", "Anas_capensis", "Anas_castanea", "Anas_sibilatrix", "Anas_cyanoptera", "Sarkidiornis_melanotos", "Somateria_mollissima", "Bucephala_clangula", "Mergus_merganser", "Aythya_ferina", "Melanitta_nigra", "Tadorna_tadorna", "Anas_crecca", "Nettapus_coromandelianus", "Lophonetta_specularioides", "Tadorna_cristata", "Anas_zonorhyncha", "Anas_eatoni", "Alopochen_aegyptiaca", "Anas_penelope", "Anas_falcata", "Tachyeres_brachypterus", "Aythya_nyroca", "Tachyeres_pteneres", "Tachyeres_patachonicus", "Stictonetta_naevosa", "Dendrocygna_bicolor", "Anas_strepera", "Anas_querquedula", "Aythya_marila", "Nettapus_pulchellus", "Anas_gracilis", "Aythya_australis", "Histrionicus_histrionicus", "Pteronetta_hartlaubii", "Anas_wyvilliana", "Lophodytes_cucullatus", "Anas_hottentota", "Chloephaga_hybrida", "Somateria_spectabilis", "Oxyura_vittata", "Anas_laysanensis", "Aythya_affinis", "Dendrocygna_javanica", "Clangula_hyemalis", "Oxyura_maccoa", "Aythya_innotata", "Anas_bernieri", "Anas_platyrhynchos", "Aix_galericulata", "Marmaronetta_angustirostris", "Nomonyx_dominicus", "Anas_melleri", "Anas_fulvigula", "Cairina_moschata", "Biziura_lobata", "Aythya_novaeseelandiae", "Anas_acuta", "Anas_clypeata", "Neochen_jubata", "Anas_superciliosa", "Tadorna_variegata", "Anas_luzonica", "Malacorhynchus_membranaceus", "Rhodonessa_caryophyllacea", "Dendrocygna_eytoni", "Anas_puna", "Tadorna_radjah", "Anas_platalea", "Anas_erythrorhyncha", "Mergus_serrator", "Netta_rufina", "Aythya_americana", "Aythya_collaris", "Callonetta_leucophrys", "Netta_peposaca", "Oxyura_jamaicensis", "Tadorna_ferruginea", "Salvadorina_waigiuensis", "Mergus_squamatus", "Anas_versicolor", "Mergellus_albellus", "Tadorna_cana", "Netta_erythrophthalma", "Speculanas_specularis", "Somateria_fischeri", "Dendrocygna_guttata", "Polysticta_stelleri", "Anas_gibberifrons", "Melanitta_perspicillata", "Merganetta_armata", "Aythya_fuligula", "Melanitta_fusca", "Dendrocygna_arcuata", "Dendrocygna_arborea", "Anas_poecilorhyncha", "Thalassornis_leuconotus", "Anas_bahamensis", "Dendrocygna_viduata", "Oxyura_leucocephala", "Tachyeres_leucocephalus", "Cairina_scutulata", "Aix_sponsa", "Anas_undulata", "Anas_georgica", "Anas_flavirostris"
        });

        public static string Gimmeaduck()
        {
            if(Educks.Count() < 2)
            {
                return Lducks[randomNum.Next(0, Educks.Count() - 1)];
            }
            return Educks[randomNum.Next(0, Educks.Count() - 1)];
        }

        public static string uniqDuck()
        {
            string choice = Gimmeaduck();
            Educks.Remove(choice);
            return choice;
        }

        private static Random randomNum = new Random();
        public static string Generator()
        {
            int threadsINT = 5;
            StringBuilder code = new StringBuilder();
            for (int i = 0; i < threadsINT; i++)
            {
                //string 
                code.Append("public class " + uniqDuck() + "{\n " + "public static void " + uniqDuck() + "()" + "{ ");

                string stringA = uniqDuck();
                string stringB = uniqDuck();
                code.Append("string " + stringA + " = \"" + uniqDuck() + "\";");
                code.Append("string " + stringB + " = \"" + uniqDuck() + "\";");
                code.Append(stringA + " = \"" + uniqDuck() + "\";");
                code.Append(stringA + " = " + stringB + ";");

                code.Append("}}");
                code.AppendLine("\n");

                //int32
                code.Append("public class " + uniqDuck() + "{\n " + "public static void " + uniqDuck() + "()" + "{ ");

                string int32A = uniqDuck();
                string int32B = uniqDuck();
                code.Append("Int32 " + int32A + " = -" + randomNum.Next(0, 132) + ";");
                code.Append("Int32 " + int32B + " = -" + randomNum.Next(0, 132) + ";");
                code.Append(int32A + " = -" + randomNum.Next(0, 132) + ";");
                code.Append(int32A + " = " + int32B + ";");

                code.Append("}}");
                code.AppendLine("\n");

                //float
                code.Append("public class " + uniqDuck() + "{\n " + "public static void " + uniqDuck() + "()" + "{ ");

                string floatA = uniqDuck();
                string floatB = uniqDuck();
                code.Append("float " + floatA + " = -" + randomNum.Next(0, 132) + ".0f;");
                code.Append("float " + floatB + " = -" + randomNum.Next(0, 132) + ".0f;");
                code.Append(floatA + " = -" + randomNum.Next(0, 132) + ".0f;");
                code.Append(floatA + " = " + floatB + ";");

                code.Append("}}");
                code.AppendLine("\n");

                //int
                code.Append("public class " + uniqDuck() + "{\n " + "public static void " + uniqDuck() + "()" + "{ ");

                string intA = uniqDuck();
                string intB = uniqDuck();
                code.Append("int " + intA + " = -" + randomNum.Next(0, 132) + ";");
                code.Append("int " + intB + " = -" + randomNum.Next(0, 132) + ";");
                code.Append(intA + " = -" + randomNum.Next(0, 132) + ";");
                code.Append(intA + " = " + intB + ";");

                code.Append("}}");
                code.AppendLine("\n");

                //boolean
                code.Append("public class " + uniqDuck() + "{\n " + "public static void " + uniqDuck() + "()" + "{ ");

                string boolA = uniqDuck();
                string boolB = uniqDuck();
                code.Append("bool " + boolA + " = true;");
                code.Append("bool " + boolB + " = false;");
                code.Append(boolA + " = false;");
                code.Append(boolA + " = " + boolB + ";");

                code.Append("}}");
                code.AppendLine("\n");
            }
            return code.ToString();
        }
    }
}

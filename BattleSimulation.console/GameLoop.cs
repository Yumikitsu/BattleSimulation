using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSimulation.console
{
    public class GameLoop
    {
        //Update function containing the entire game loop

        /* -START OF GAME-
         * Print out all information necessary about the game and then let the player select a starter monster:
         * 1. Starter 1
         * 2. Starter 2
         * 3. Starter 3
         * 
         * -ROUTE-
         * If on a route player can choose:
         * 1. Wild encounter
         * 2. Open menu
         * 3. Go to shop
         * 
         * -SHOP-
         * If in a shop player can choose:
         * 1. Buy stuff
         * 2. Sell stuff
         * 3. Open menu
         * 4. Go to healing center
         * 
         * If buying stuff player can choose:
         * 1. Buy item 1
         * 2. Buy item 2
         * 3. Buy item 3
         * 4. Buy item 4
         * 5. Cancel
         * 
         * When buying a selected item, player can then type in the amount of said item they want to buy:
         * 1-99. Amount
         * 0. Cancel
         * 
         * -HEALING CENTER-
         * If in a healing center player can choose:
         * 1. Fully heal party
         * 2. Heal selected monster
         * 3. Open menu
         * 4. Go to gym battle
         * 
         * If healing selected monster player can choose:
         * 1-6. Select monster
         * 7. Cancel
         * 
         * -BATTLE-
         * If in a battle of any kind player can choose:
         * 1. Select move
         * 2. Open menu
         * 3. Swap monster
         * 4. Run (Only works on wild encounters)
         * 
         * If in select move menu player can choose:
         * 1. Move 1
         * 2. Move 2
         * 3. Move 3
         * 4. Move 4
         * 5. Cancel
         * 
         * If swap monster is selected player can choose:
         * 1-6. Select monster
         * 7. Cancel
         * 
         * If your monster dies player can choose a new alive one from party:
         * 1-6. Select monster
         * 
         * If no monsters are left alive, player loses
         * 
         * -MENU-
         * If in menu player can choose:
         * 1. View party
         * 2. Open inventory
         * 3. Close menu
         * 
         * -MONSTER PARTY-
         * If in party player can choose:
         * 1. Select monster 1
         * 2. Select monster 2
         * 3. Select monster 3
         * 4. Select monster 4
         * 5. Select monster 5
         * 6. Select monster 6
         * 7. Close party
         * 
         * If a monster is selected player can choose:
         * 1. View stats/moves (Print out the stats and moves with their uses left, description, power, typing and special or physical)
         * 2. Switch to start position
         * 3. Cancel
         * 
         * -INVENTORY-
         * If in inventory player can choose:
         * 1-8. Select item (print the description at this point as well)
         * 9. Go to next page if there is one
         * 0. Close inventory
         * 
         * If item is selected player can choose:
         * 1. Use
         * 2. Cancel
         * 
         * If item is usable on a party member player can choose:
         * 1-6. Select monster
         * 7. Cancel
         * 
         * -END OF THE GAME-
         * Player wins after the final gym battle is completed
        */
    }
}

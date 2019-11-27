using Otter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlchemistJam
{
    class GameManager
    {
               
        public void StartGame(Scene scene)
        {
            var mainGame = new Game("Chemical Mage",860,640);
            mainGame.MouseVisible = true;
            mainGame.Start(scene);
            
        }
       
       
    }

    class Laboratory : Entity
    {
        public Laboratory(float x, float y, string imagePath) : base(x, y)
        {
            //Create an image using the path passed in with constructor
            var image = new Image(imagePath);
            //Add the image  to the Entity's Graphic list. 
            image.CenterOrigin();
            AddGraphic(image);
        }
    }
}

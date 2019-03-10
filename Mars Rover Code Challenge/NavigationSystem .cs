using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars_Rover_Code_Challenge
{
    class NavigationSystem
    {
        private int viewDirection = 0;
        private int xLocation = 0, yLocation = 0;
        private int xBound = 0, yBound = 0;
        private void rationaliseLocation()
        {
            while (viewDirection < 0)
                viewDirection = 360 + viewDirection;
            if (viewDirection >= 360)
                viewDirection %= 360;
        }
        private bool boundsCheck()
        {
            bool outOfBounds = false;
            while ((xLocation < 0) || (xLocation > xBound))
            if (xLocation < 0)
            {
                xLocation++;
                outOfBounds = true;
            }
            else if (xLocation > xBound)
            {
                xLocation--;
                outOfBounds = true;
            }
            while ((yLocation < 0) || (yLocation > yBound))
            if (yLocation < 0)
            {
                yLocation++;
                outOfBounds = true;
            }
            else if (yLocation > yBound)
            {
                yLocation--;
                outOfBounds = true;
            }
            return outOfBounds;
        }
        public bool setHeading(string headding = "N")
        {
            headding = headding.ToUpper();
            if (headding == "N")
                viewDirection = 0;
            else if (headding == "E")
                viewDirection = 90;
            else if (headding == "S")
                viewDirection = 180;
            else if (headding == "W")
                viewDirection = 270;
            else
                return false;
            return true;
        }
        public bool setLocation(int X = 0, int Y = 0)
        {
            xLocation = X;
            yLocation = Y;
            return boundsCheck();
        }
        public void setBounds(int x = 0, int y = 0)
        {
            xBound = x;
            yBound = y;
        }
        public bool move()
        {
            if (viewDirection == 0)
                yLocation++;
            else if (viewDirection == 90)
                xLocation++;
            else if (viewDirection == 180)
                yLocation--;
            else if (viewDirection == 270)
                xLocation--;
            return !boundsCheck();
        }
        public void leftTurn()
        {
            viewDirection -= 90;
            rationaliseLocation();
        }
        public void rightTurn()
        {
            viewDirection += 90;
            rationaliseLocation();
        }
        public int getXLocation()
        {
            return xLocation;
        }
        public int getYLocation()
        {
            return yLocation;
        }
        public int[] getLocation()
        {
            int[] location = new int[2];
            location.SetValue(xLocation, 0);
            location.SetValue(yLocation, 1);
            return location;
        }
        public int[] getBounds()
        {
            int[] bounds = new int[2];
            bounds.SetValue(xBound, 0);
            bounds.SetValue(yBound, 1);
            return bounds;
        }
        public string getHeading(bool compassPoint = true)
        {
            if (compassPoint == true)
            {
                if (viewDirection == 0)
                    return "N";
                else if (viewDirection == 90)
                    return "E";
                else if (viewDirection == 180)
                    return "S";
                else if (viewDirection == 270)
                    return "w";
                else
                    return "Unknown";
            }                
            else
                return viewDirection.ToString();
        }
    }
}

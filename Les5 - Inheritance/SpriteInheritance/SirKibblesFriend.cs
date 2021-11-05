using System.Drawing;

namespace Eindopdracht
{
	class SirkibblesFriend : Sprite
	{
		public SirkibblesFriend(RectangleF screenPosition)
        {
			this.screenPosition = screenPosition;
			imageFrame = new Rectangle(35, 120, 16, 16);
        }
	}
}

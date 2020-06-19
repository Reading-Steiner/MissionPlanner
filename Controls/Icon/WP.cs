using System.Drawing;

namespace MissionPlanner.Controls.Icon
{

    class WP : Icon
    {
        internal override void doPaint(Graphics g)
        {
            var mid = Width / 2;
            var quartmid = mid / 4;
            var offset_x = quartmid;
            var offset_y = quartmid;
            Point p1 = new Point(2 * quartmid + offset_x, 6 * quartmid + offset_y);
            Point p2 = new Point(6 * quartmid + offset_x, 2 * quartmid + offset_y);
            g.DrawLine(LinePen, p1, p2);
            p1 = new Point(2 * quartmid + offset_x, 2 * quartmid + offset_y);
            p2 = new Point(3 * quartmid + offset_x, 5 * quartmid + offset_y);
            g.DrawLine(LinePen, p1, p2);
            p1 = new Point(6 * quartmid + offset_x, 6 * quartmid + offset_y);
            p2 = new Point(3 * quartmid + offset_x, 5 * quartmid + offset_y);
            g.DrawLine(LinePen, p1, p2);
            p1 = new Point(5 * quartmid + offset_x, 1 * quartmid + offset_y);
            p2 = new Point(7 * quartmid + offset_x, 3 * quartmid + offset_y);
            g.DrawLine(LinePen, p1, p2);
        }
    }
}


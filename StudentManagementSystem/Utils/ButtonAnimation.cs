using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.Utils
{
    class ButtonAnimation
    {

        /*
         * Add hover animation.
         */ 
        public static void addAnimation(System.Windows.Forms.Label label) {
            label.BackColor = System.Drawing.Color.FromArgb(28, 38, 48);
            label.ForeColor = System.Drawing.Color.White;
            label.Font = new System.Drawing.Font("Microsoft NeoGothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        public static void addBold(System.Windows.Forms.Label label) {
            label.ForeColor = System.Drawing.Color.White;
            label.Font = new System.Drawing.Font("Microsoft NeoGothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        /*
         * Remove hover animation.
         */
        public static void restore(System.Windows.Forms.Label label) {
            label.BackColor = System.Drawing.Color.FromArgb(54, 57, 62);
            label.ForeColor = System.Drawing.SystemColors.ControlDark;
            label.Font = new System.Drawing.Font("Microsoft NeoGothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        /*
         * Add click animation.
         */
        public static void addClickedEffect(System.Windows.Forms.Panel panel) {
            panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        }

        /*
         * Remove click animation.
         */
        public static void removeClickedEffect(System.Windows.Forms.Panel panel) {
            panel.BorderStyle = System.Windows.Forms.BorderStyle.None;
        }
    }
}

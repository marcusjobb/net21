// -----------------------------------------------------------------------------------------------
//  BuildABear.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace SimpleBuilder.Builders
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using SimpleBuilder.Interface;
    using SimpleBuilder.Models;
    internal class BuildABear
    {
        private Bear bear = new Bear();
        public BuildABear()
        {
            CreateGenericBear(); // Sätt standardegenskaper
        }
        public BuildABear AddLeg(string leg)
        {
            var arr = bear.Legs.ToList();
            arr.Add(new Legs { Name = leg });
            bear.Legs = arr.ToArray();
            return this;
        }
        public BuildABear AddArm(string arm)
        {
            var arr = bear.Arms.ToList();
            arr.Add(new Arms { Name = arm });
            bear.Arms = arr.ToArray();
            return this;
        }

        public BuildABear SetHead(string eyeColor = "brown", string mouthExpression = "Happy")
        {
            bear.Head = new Head { EyeColor = eyeColor, MouthExpression = mouthExpression };
            return this;
        }
        public BuildABear SetEyeColor(string eyeColor)
        {
            bear.Head.EyeColor = eyeColor;
            return this;
        }
        public BuildABear SetMouthExpression(string mouthExpression)
        {
            bear.Head.MouthExpression = mouthExpression;
            return this;
        }

        public BuildABear SetTorsoColor(string color)
        {
            bear.Torso = new Torso { Color = color };
            return this;
        }
        public BuildABear SetColor(string color)
        {
            bear.Color = color;
            return this;
        }
        public BuildABear SetName(string name)
        {
            bear.Name = name;
            return this;
        }

        public BuildABear CreateGenericBear()
        {
            bear = new Bear
            (
                new Legs[]
                {
                    new Legs{Name="Left leg"},
                    new Legs{Name="Right leg"}
                },
                new Arms[] {
                    new Arms { Name = "Left arm" },
                    new Arms { Name = "Right arm" }
                },
                new Head { EyeColor = "Brown", MouthExpression = "Frown" },
                new Torso { Color = "Light brown" },
                "Teddybear",
                "Brown"
            );
            return this;
        }
        public Bear Build() => bear;
    }
}

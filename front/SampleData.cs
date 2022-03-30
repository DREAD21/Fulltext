using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using front.Models;

namespace front
{
    public class SampleData
    {
        public static void Initialize(TextContext context)
        {
            if (!context.Texts.Any())
            {
                context.Texts.AddRange(
                    new Text
                    {
                        text = "qwerty"
                    },
                    new Text
                    {
                        text = "asdfg"
                    },
                    new Text 
                    {
                        text = "qwertyu"
                    },
                    new Text
                    {
                        text = "qwertyasdf"
                    }
                    );
            }
        }
    }
}

using System.Text.RegularExpressions;
using artificially_infused.Services;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FindAndReplace()
        {
            string template = "A {NOUN} riding a unicycle while juggling multiple {NOUN}.";
            List<string> words = new List<string>(new string[] { "one", "two", "three" });
            Regex yourRegex = new Regex(@"\{([^\}]+)\}");
            foreach (string w in words)
            {
                template = yourRegex.Replace(template, w, 1);
                
            }
            Assert.IsTrue(template.Contains("one"));

        }
    }
}
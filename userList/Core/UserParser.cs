using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using userList.Models;

namespace userList.Core
{
    public class UserParser
    {
        public static IEnumerable<User> Parse(string path)
        {
            foreach (var line in File.ReadAllLines(path).Skip(1))
            {
                string[] props = line.Split(';');
                yield return new User(
                    Convert.ToInt32(props[0]),
                    props[1],
                    props[2],
                    props[3],
                    Convert.ToDateTime(props[4]),
                    Convert.ToDouble(props[5]),
                    props[6],
                    props[7],
                    props[8]
                    );
            }
        }
    }
}

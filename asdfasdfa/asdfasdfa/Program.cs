using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asdfasdfa
{
	class Program
	{
		int test(int c,int d)
		{
			int x = c - d;
			Console.Write("%d %d", c, d);
			return x;
		}
		static void Main(string[] args)
		{
			int a = 2, b = 6;
			int y = test(b, a);
			Console.Write("%d %d %d",a,b,y);
				
			}
		}
	}


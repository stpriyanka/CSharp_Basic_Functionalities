using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
	//http://www.c-sharpcorner.com/UploadFile/d0e913/abstract-class-interface-two-villains-of-every-interview/
	public abstract class iPhone
	{
		public void Call()
		{
			Console.WriteLine("Call Method: This method provides Calling features");
		}
		public abstract void Model();
	}

	class iPhone5s : iPhone
	{
		public override void Model()
		{
			Console.WriteLine("Model: The model of this iPhone is iPhone5s");
		}

		public void LaunchDate()
		{
			Console.WriteLine("Launch Date: This iPhone was launched on 20-September-2013");
		}
	}



	public class Iphone6s : iPhone 
	{
		public override void Model()
		{
			Console.WriteLine("Model: The model of this iPhone is iPhone6s");

		}

	}

	class Program
	{
		static void Main(string[] args)
		{
			iPhone5s iphone5s = new iPhone5s();
			Iphone6s i6s = new Iphone6s();
			iphone5s.Call();
			iphone5s.Model();
			iphone5s.LaunchDate();
			
			i6s.Model();
			Console.ReadKey();
		}
	}   
}

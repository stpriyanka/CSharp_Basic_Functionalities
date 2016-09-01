using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Machine.Specifications;

namespace Mspec
{
	
	[Subject("something")]
	public class when_index_action_is_invoked
	{
		static int _value;

		Establish _context =
			() =>
			{
				_value = 2;
			};

		private Because _of = () =>
			_value = +_value;

		It _shouldAddValues = () => _value.ShouldEqual(4);
	}
}

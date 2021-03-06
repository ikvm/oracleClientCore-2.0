//
// System.Data.OracleClient.OracleClientFactory.cs
//
// Author:
//   Sureshkumar T (tsureshkumar@novell.com)
//
//
// Copyright (C) 2004 Novell, Inc (http://www.novell.com)
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

namespace System.Data.OracleClient
{
	using System.Data;
	using System.Data.Common;
	using System.Security;
	using System.Security.Permissions;

	public sealed class OracleClientFactory : DbProviderFactory
	{
		#region Fields
		public static readonly OracleClientFactory Instance = new OracleClientFactory();
		#endregion //Fields

		#region Constructors

		private OracleClientFactory () {

		}

		#endregion //Constructors

		public override bool CanCreateDataSourceEnumerator {
			get { throw new NotImplementedException (); }
		}

		#region public overrides
		public override DbCommand CreateCommand () {
			return new OracleCommand ();
		}

		public override DbCommandBuilder CreateCommandBuilder () {
			return new OracleCommandBuilder ();
		}

		public override DbConnection CreateConnection () {
			return new OracleConnection ();
		}

		public override DbConnectionStringBuilder CreateConnectionStringBuilder () {
			return new OracleConnectionStringBuilder ();
		}

/*
		public override CodeAccessPermission CreatePermission (PermissionState state) {
			return new OraclePermission (state);
		}
*/

		public override DbDataAdapter CreateDataAdapter () {
			return new OracleDataAdapter ();
		}

		public override DbDataSourceEnumerator CreateDataSourceEnumerator () {
			// Note: there is no OracleDataSourceEnumerator.  
			// .net 2.0 returns a null here instead of an exception
			return null;
		}

		public override DbParameter CreateParameter () {
			return new OracleParameter ();
		}

		#endregion // public overrides
	}
}

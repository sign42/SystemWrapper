using NUnit.Framework;
using Rhino.Mocks;

namespace UnitWrappers.Tests.System.Data.SqlClient
{
    [TestFixture]
	public class SqlDataReaderWrapTests
    {
    	private MockRepository _mockRepository;

            [SetUp]
			public void Setup()
			{
				_mockRepository = new MockRepository();
			}

			//there is no default constructor for a SqlDataReader so we cannot mock it.
			//Can't figure out how to test this.

			//[Test]
			//public void Constructor_Sets_Connection_Instance()
			//{
			//  var mockReader = _mockRepository.Stub<SqlDataReader>();
			//  var instance = new SqlDataReaderWrap(mockReader);
			//  Assert.AreSame(mockReader, instance.UnderlyingObject);
			//}


			//[Test]
			//public void Initialize_Sets_Command_Instance()
			//{
			//  var mockReader = _mockRepository.Stub<SqlDataReader>();
			//  var instance = new SqlDataReaderWrap();
			//  instance.Initialize(mockReader);
			//  Assert.AreSame(mockReader, instance.UnderlyingObject);
			//}

    }
}
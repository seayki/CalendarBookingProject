using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendardarBooking.Infrastructure.Test 
{
    public class IsBookingOverlappingDomainServiceTest 
    {

        [Fact]
        public void IsBookingOverlapping()
            {
            // arrange
            var authorsList = GetFakeStudentsList(); 
            var articleList = GetFakeBookingsList(); 

            var publicationContextMock = new Mock<PublicationContext>();
            publicationContextMock.Setup(x => x.Authors).ReturnsDbSet(authorsList);
            publicationContextMock.Setup(x => x.Articles).ReturnsDbSet(articleList);


          

            });
          


            // act
          


            // assert
          


        }

        private List<Student> GetFakeBookingsList() 
        {
            var students = new List<Students>();

            var author1 = new AuthorEntity() {
                Id = 1,
                Name = "Author1",
            };
            var author2 = new AuthorEntity() {
                Id = 2,
                Name = "Author2",
            };
            var author3 = new AuthorEntity() {
                Id = 3,
                Name = "Author3",
            };
        }

        private List<Student> GetFakeStudentsList() 
        {
        
        }
    }
}


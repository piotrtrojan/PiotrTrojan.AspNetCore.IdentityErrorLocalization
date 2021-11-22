using HttpContextMoq;
using HttpContextMoq.Extensions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Primitives;
using Moq;
using PiotrTrojan.AspNetCore.IdentityErrorLocalization.de_DE;
using PiotrTrojan.AspNetCore.IdentityErrorLocalization.es_ES;
using PiotrTrojan.AspNetCore.IdentityErrorLocalization.fa_IR;
using PiotrTrojan.AspNetCore.IdentityErrorLocalization.fr_FR;
using PiotrTrojan.AspNetCore.IdentityErrorLocalization.pl_PL;
using PiotrTrojan.AspNetCore.IdentityErrorLocalization.pt_PT;
using PiotrTrojan.AspNetCore.IdentityErrorLocalization.ru_RU;
using PiotrTrojan.AspNetCore.IdentityErrorLocalization.sv_SE;
using PiotrTrojan.AspNetCore.IdentityErrorLocalization.tr_TR;
using PiotrTrojan.AspNetCore.IdentityErrorLocalization.uk_UA;
using System;
using System.Collections.Generic;
using Xunit;

namespace PiotrTrojan.AspNetCore.IdentityErrorLocalization.Test
{
    public class MultilangTest
    {
        [Fact]
        public void DiTest()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddMultilangIdentityErrorDescriberFactory();
            var sp = serviceCollection.BuildServiceProvider();
            var factory = sp.GetService<IdentityErrorDescriberFactory>();
            Assert.NotNull(factory);
        }

        [Theory]
        [InlineData("de", typeof(GermanIdentityErrorDescriber), typeof(IdentityErrorDescriber))]
        [InlineData("es", typeof(SpanishIdentityErrorDescriber), typeof(IdentityErrorDescriber))]
        [InlineData("fa", typeof(PersianIdentityErrorDescriber), typeof(IdentityErrorDescriber))]
        [InlineData("fr", typeof(FrenchIdentityErrorDescriber), typeof(IdentityErrorDescriber))]
        [InlineData("pl", typeof(PolishIdentityErrorDescriber), typeof(IdentityErrorDescriber))]
        [InlineData("pt", typeof(PortugueseIdentityErrorDescriber), typeof(IdentityErrorDescriber))]
        [InlineData("ru", typeof(RussianIdentityErrorDescriber), typeof(IdentityErrorDescriber))]
        [InlineData("sv", typeof(SwedishIdentityErrorDescriber), typeof(IdentityErrorDescriber))]
        [InlineData("tr", typeof(TurkishIdentityErrorDescriber), typeof(IdentityErrorDescriber))]
        [InlineData("uk", typeof(UkrainianIdentityErrorDescriber), typeof(IdentityErrorDescriber))]
        public void MultilanguageFactoryTest<T>(string lang, Type validDescriberType, Type invalidDescriberType)
        {
            var serviceCollection = new ServiceCollection();
            var httpContextMock = new HttpContextMock();
            httpContextMock.SetupRequestHeaders(new Dictionary<string, StringValues>
            {
                { "Accept-Language", lang }
            });
            var mockHttpContextAccessor = new Mock<IHttpContextAccessor>();
            mockHttpContextAccessor.Setup(_ => _.HttpContext).Returns(httpContextMock);
            serviceCollection.AddTransient<IHttpContextAccessor>(sp =>
            {
                return mockHttpContextAccessor.Object;
            });

            var validErrorDescriber = (IdentityErrorDescriber)Activator.CreateInstance(validDescriberType);
            var invalidErrorDescriber = (IdentityErrorDescriber)Activator.CreateInstance(invalidDescriberType);

            serviceCollection.AddMultilangIdentityErrorDescriberFactory();
            var factory = serviceCollection.BuildServiceProvider().GetService<IdentityErrorDescriberFactory>();

            Assert.NotNull(factory);
            Assert.Equal(factory.GetDescriber().DefaultError().Description, validErrorDescriber.DefaultError().Description);
            Assert.NotEqual(factory.GetDescriber().DefaultError().Description, invalidErrorDescriber.DefaultError().Description);
        }

        // TODO: Additional tests of dependency injection should be done here (e.g. AddTurkishIdentityErrorDescriber)

    }
}

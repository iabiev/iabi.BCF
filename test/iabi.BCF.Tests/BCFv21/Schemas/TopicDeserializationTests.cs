using System.Linq;
using Xunit;

namespace iabi.BCF.Tests.BCFv21.Schemas
{
    public class TopicDeserializationTests
    {
        [Fact]
        public void CanDeserializeTopicWithRelatedTopic()
        {
            var xmlTopic = @"<Topic Guid=""a6f801b9-6bf6-4cb9-8b89-1ae24b76074a"" TopicType=""Error"" TopicStatus=""Open"">
        <Title>Related topic B</Title>
        <CreationDate>2017-05-22T12:12:15.621Z</CreationDate>
        <CreationAuthor>jon.anders.sollien@catenda.no</CreationAuthor>
        <ModifiedDate>2017-05-22T12:12:15.621Z</ModifiedDate>
        <Description></Description>
        <RelatedTopic Guid=""c69c8879-bd4a-4182-a759-f3c8c5b47c94""/>
    </Topic>";
            var deserializedTopic = BCF.BCFv21.Schemas.Topic.Deserialize(xmlTopic);
            Assert.True(deserializedTopic.ShouldSerializeRelatedTopic());
            Assert.Equal(1, deserializedTopic.RelatedTopic.Count);
            Assert.Equal("c69c8879-bd4a-4182-a759-f3c8c5b47c94", deserializedTopic.RelatedTopic.First().Guid);
        }
    }
}
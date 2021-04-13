using System;

namespace RobotizeFacebook.App.LoggedIn
{
    public class FeedContainerPages : Feed
    {
        public FeedContainerPages(string baseXPath = null, string positionXPath = null) : base(baseXPath, positionXPath)
        {
        }

        public override string FeedUrl => throw new NotImplementedException();

        public override void RunConformance()
        {
            throw new NotImplementedException();
        }
    }
}

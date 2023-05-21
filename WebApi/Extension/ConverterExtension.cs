namespace WebApi.Extension
{
    public static class ConverterExtension
    {
        public static DAL.Models.User ConvertToUser(this WebApi.Models.UserM UserM)
        {
            return new DAL.Models.User
            {
                UserId = UserM.Id,
                Firstname = UserM.Firstname,
                Lastname = UserM.Lastname,
                Username = UserM.Username,
                CardId = UserM.CardId,
                Card = ConvertToCard(UserM.Card)
            };
        }
        public static WebApi.Models.UserM ConvertToUserM(this DAL.Models.User User)
        {
            return new WebApi.Models.UserM
            {
                Id = User.UserId,
                Firstname = User.Firstname,
                Lastname = User.Lastname,
                Username = User.Username,
                CardId = User.CardId,
                Card = ConvertToCardM(User.Card)
            };
        }
        public static DAL.Models.Card ConvertToCard(this WebApi.Models.CardM CardM)
        {
            return new DAL.Models.Card
            {
                CardId = CardM.Id,
                Quota = CardM.Quota,
                UserId = CardM.UserId,
                User = ConvertToUser(CardM.User)
            };
        }
        public static WebApi.Models.CardM ConvertToCardM(this DAL.Models.Card Card) 
        {
            return new WebApi.Models.CardM
            {
                Id = Card.CardId,
                Quota = Card.Quota,
                UserId = Card.UserId,
                User = ConvertToUserM(Card.User)
            };
        }

    }
}

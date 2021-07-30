using System.Data;

namespace IT
{
    public class CardAction: DataAccess
    {
        public static DataSet FillCard()
        {
            return DataAccess.FillCard();
        }

        public static void Add(Card card)
        {
            AddCard(card);
        }

        public static void Edit(Card card)
        {
            EditCard(card);
        }

        public static void Del(Card card)
        {
            DeleteCardAndMovement(card);
        }
    }
}

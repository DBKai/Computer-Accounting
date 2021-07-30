using System.Data;

namespace IT
{
    public class MovementAction: DataAccess
    {
        public static DataSet FillMovement(int idCard)
        {
            return DataAccess.FillMovement(idCard);
        }

        public static void Add(Movement movement)
        {
            AddMovement(movement);
        }

        public static void Edit(Movement movement)
        {
            EditMovement(movement);
        }

        public static void Del(Movement movement)
        {
            DelMovement(movement);
        }
    }
}

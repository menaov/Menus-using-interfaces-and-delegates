namespace Menus.Delegates
{
    public delegate void ChooseOperationEventHandler();

    public class Operation : MenuItem
    {

        public event ChooseOperationEventHandler OperationChoosen;

        public Operation(string i_Name) : base(i_Name)
        {
        }

        protected virtual void OnOperationChosen()
        {
            if (OperationChoosen != null)
            {
                OperationChoosen.Invoke();
            }
        }

        
        public override void Action(int i_Level)
        {
            OnOperationChosen();
        }
    }
}

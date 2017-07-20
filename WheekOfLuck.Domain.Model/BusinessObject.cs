
using DrawGame.Domain.Model.Core;

namespace DrawGame.Domain.Model
{
    public class BusinessObject: NotificationObject
    {
        
        private ObjectState _objectState;

        public ObjectState ObjectState
        {
            get { return _objectState; }
            set
            {
                if (_objectState != value)
                {
                    _objectState = value;
                    
                    OnPropertyChanged("ObjectState");
                    ObjectStateChanged();
                }
                
            }
        }

        public void MarkUnchanged()
        {
            ObjectState = ObjectState.Unchanged;
        }

        public void MarkDeleted()
        {
            ObjectState= ObjectState.Deleted;
        }

        public void MarkNew()
        {
            ObjectState = ObjectState.New;
        }

        public void MarkModified()
        {
            ObjectState = ObjectState.Modified;
        }

        private void ObjectStateChanged()
        {

            switch (_objectState)
            {
                case  ObjectState.Deleted:
                    break;
                case  ObjectState.Modified:
                    break;
                case  ObjectState.New:
                    break;
                case ObjectState.Unchanged:
                    ObjectState= ObjectState.Unchanged;
                    break;
            }

        }


    }




    public class BusinessObjectCollection
    {
        

    }
}
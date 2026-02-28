using Common.Services;
using UnityEngine;

namespace Common.Input
{
    public class InputService : BaseService
    {
        public InputReader InputReader;

        protected override void OnInit()
        {
            base.OnInit();

            Debug.Log("InputService Init");
            InputReader = Resources.Load<InputReader>("Common/Input/InputReader");
            InputReader.Init();
        }
    }
}
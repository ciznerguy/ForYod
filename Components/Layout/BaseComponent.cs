using Microsoft.AspNetCore.Components;
using ForYod.Components.Services;

namespace ForYod.Components
{
    public class BaseComponent : LayoutComponentBase
    {
        [Inject]
        public UserService UserService { get; set; }
        


        public string UserFullName => UserService.FullName;
    }
}

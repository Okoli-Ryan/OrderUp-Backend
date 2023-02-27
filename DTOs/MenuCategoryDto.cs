﻿namespace OrderUp_API.DTOs {
    public class MenuCategoryDto : AbstractDto{


        public string categoryName { get; set; }

        public Guid restaurantId { get; set; }

        //public Restaurant restaurant { get; set; }

        public List<MenuItemDto> menuItems { get; set; }
    }
}

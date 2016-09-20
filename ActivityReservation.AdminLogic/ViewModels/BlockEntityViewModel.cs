﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ActivityReservation.AdminLogic.ViewModels
{
    public class BlockEntityViewModel
    {
        /// <summary>
        /// 黑名单类型id
        /// </summary>
        [Required]
        public Guid BlockTypeId { get; set; }

        /// <summary>
        /// 黑名单类型名称
        /// </summary>
        [Required]
        public string BlockTypeName { get; set; }

        /// <summary>
        /// 拉入黑名单的值
        /// </summary>
        [Required]
        public string BlockValue { get; set; }     
    }
}
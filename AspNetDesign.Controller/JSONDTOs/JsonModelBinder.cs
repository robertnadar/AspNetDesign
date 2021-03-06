﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace AspNetDesign.Controller.JSONDTOs
{
    public class JsonModelBinder :IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            if (controllerContext == null)
            {
                throw new ArgumentNullException("controllerContext");
            }
            if (bindingContext == null)
            {
                throw new ArgumentNullException("bindingContext");
            }
            var serializer = new DataContractJsonSerializer(bindingContext.ModelType);
            controllerContext.HttpContext.Request.InputStream.Position = 0;
            return serializer.ReadObject(controllerContext.HttpContext.Request.InputStream);
        }
    }
}

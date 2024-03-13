var HRMS = {};

HRMS.BindCurrency = function () {

    $.getJSON("/Currency/GetCurrency", function (response) {
        $(".currencyDropdown").empty();
        $.each(response, function () {
            $(".currencyDropdown").append($("<option />").val(this.Id).text(this.Name));
        });
        if ($('#cuID').val() != undefined) {
            $('.currencyDropdown').val($('#cuID').val());
        }
    })

}

HRMS.BindCountry = function () {
    $.getJSON("/Country/GetCountry", function (response) {
        $(".countryDropdown").empty();
        $(".countryDropdown").append($("<option />").val(null).text("Select Country"));
        $.each(response, function () {
            $(".countryDropdown").append($("<option />").val(this.Id).text(this.Name));
        });
        if ($('#cID').val() != undefined) {
            $('.countryDropdown').val($('#cID').val());
            $('.countryDropdown').trigger('change');
        }
    })
}

HRMS.ConfimrDelete = function () {
    $(document).on("click", ".deleteRecord", function (e) {
        var me = this;
        e.preventDefault();
        Lobibox.confirm({
            type: "success",
            msg: "Are you sure you want to delete this record?",
            callback: function (lobibox, type) {
                if (type === "yes") {
                    window.location = $(me).attr("href");
                }
            }
        });
    });

}


HRMS.BindEmployeeType = function () {

    $.getJSON("/EmployeeType/GetEmployeeType", function (response) {
        $(".employeeTypeDropdown").empty();
        $.each(response, function () {
            $(".employeeTypeDropdown").append($("<option />").val(this.Id).text(this.Name));
        });
        if ($('#eTID').val() != undefined) {
            $('.employeeTypeDropdown').val($('#eTID').val());
        }
    })

}


HRMS.BindDepartmentType = function () {

    $.getJSON("/DepartmentType/GetDepartmentType", function (response) {
        $(".departmentTypeDropdown").empty();
        $.each(response, function () {
            $(".departmentTypeDropdown").append($("<option />").val(this.Id).text(this.Name));
        });
        if ($('#dTID').val() != undefined) {
            $('.departmentTypeDropdown').val($('#dTID').val());
        }
    })

}



HRMS.BindCompany = function () {

    $.getJSON("/Company/GetCompany", function (response) {
        $(".companyDropdown").empty();
        $.each(response, function () {
            $(".companyDropdown").append($("<option />").val(this.Id).text(this.CompanyName));
        });
        if ($('#companyID').val() != undefined) {
            $('.companyDropdown').val($('#companyID').val());
        }
    })

}


HRMS.BindChangeDll = function () {
    // companychange event for braches based on companyId
    $('#ddlcompany').change(function () {
        var value = $(this).val();
   // HRMS.BindBranch(value);

    });
}

HRMS.BindBranch = function (value) {
    
    //var value = $('.companyDropdown').val($('#companyID').val());
  
    $.getJSON("/Branch/GetBranch?companyID="+value, function (response) {
        $(".branchDropdown").empty();
        $.each(response, function () {
            $(".branchDropdown").append($("<option />").val(this.Id).text(this.LocationName));
        });
        if ($('#branchId').val() != undefined) {
            $('.branchDropdown').val($('#branchId').val());
        }
    })

}
HRMS.BindAllBranch = function (value) {
    
    //var value = $('.companyDropdown').val($('#companyID').val());

    $.getJSON("/Branch/GetALLBranchs", function (response) {
        $(".branchDropdown").empty();
        $.each(response, function () {
            $(".branchDropdown").append($("<option />").val(this.Id).text(this.LocationName));
        });
        if ($('#branchId').val() != undefined) {
            $('.branchDropdown').val($('#branchId').val());
        }
    })
}
HRMS.BindAllDepartments = function (value) {
    
    //var value = $('.companyDropdown').val($('#companyID').val());

    $.getJSON("/Department/GetAllDepartment", function (response) {
        $(".DepartmentDropDown").empty();
        $(".DepartmentDropdown").append($("<option />").val(null).text("Select DepartmentDropDown"));
        $.each(response, function () {
            $(".DepartmentDropDown").append($("<option />").val(this.Id).text(this.Name));
        });
        // VAR  IDD = $('#DepartmentId').val();
        if ($('#DepartmentId').val() != undefined) {
            $('.DepartmentDropDown').val($('#DepartmentId').val());
        }
        $('.DepartmentDropDown').val($('#DepartmentId').val());

    })
}

HRMS.GetAllDesgination = function (value) {
    
    $.getJSON("/Designation/GetAllDesgination", function (response) {
        $(".DesigantionDropDown").empty();
        $(".DesigantionDropDown").append($("<option />").val(null).text("Select DesigantionDropDown"));
        $.each(response, function () {
            $(".DesigantionDropDown").append($("<option />").val(this.Id).text(this.Name));
        });
        if ($('#DesignationId').val() != undefined) {
            $('.DesigantionDropDown').val($('#DesignationId').val());
        }
        $('.DesigantionDropDown').val($('#DesignationId').val());
    })
}
HRMS.GetAllEmployeeTpye = function (value) {
    
    $.getJSON("/EmployeeType/GetAllEmployeeTpye", function (response) {
        $(".EmployeeTpyeDropDown").empty();
        $(".EmployeeTpyeDropDown").append($("<option />").val(null).text("Select EmployeeTpyeDropDown"));
        $.each(response, function () {
            $(".EmployeeTpyeDropDown").append($("<option />").val(this.Id).text(this.Name));
        });
        if ($('#EmployeeTypeId').val() != undefined) {
            $('.EmployeeTpyeDropDown').val($('#EmployeeTypeId').val());
        }
        $('.EmployeeTpyeDropDown').val($('#EmployeeTypeId').val());
    })
}
HRMS.GetAllEmployeeRole = function (value) {
    
    $.getJSON("/Role/GetAllEmployeeRole", function (response) {
        $(".EmployeeRoleDropDown").empty();
        $(".EmployeeRoleDropDown").append($("<option />").val(null).text("Select EmployeeRoleDropDown"));
        $.each(response, function () {
            $(".EmployeeRoleDropDown").append($("<option />").val(this.Id).text(this.Name));
        });
        if ($('#DesignationId').val() != undefined) {
            $('.EmployeeRoleDropDown').val($('#RoleId').val());
        }
        $('.EmployeeTpyeDropDown').val($('#RoleId').val());
    })
}
HRMS.GetAllEmployeeSubType = function (value) {
    
    $.getJSON("/EmployeeSubType/GetAllEmployeeSubType", function (response) {
        $(".EmployeeSubTypeDropDown").empty();
        $(".EmployeeSubTypeDropDown").append($("<option />").val(null).text("Select EmployeeSubTypeDropDown"));
        $.each(response, function () {
            $(".EmployeeSubTypeDropDown").append($("<option />").val(this.Id).text(this.Name));
        });
        if ($('#EmployeeStatusId').val() != undefined) {
            $('.EmployeeSubTypeDropDown').val($('#EmployeeStatusId').val());
        }
        $('.EmployeeSubTypeDropDown').val($('#EmployeeStatusId').val());
    })
}
HRMS.GetAllEmployeeStatus = function (value) {
    
    $.getJSON("/EmployeeStatus/GetAllEmployeeStatus", function (response) {
        $(".EmployeeStatusDropDown").empty();
        $(".EmployeeStatusDropDown").append($("<option />").val(null).text("Select EmployeeStatusDropDown"));
        $.each(response, function () {
            $(".EmployeeStatusDropDown").append($("<option />").val(this.Id).text(this.Name));
        });
        if ($('#EmployeeTypeId').val() != undefined) {
            $('.EmployeeStatusDropDown').val($('#EmployeeStatusId').val());
        }
        $('.EmployeeStatusDropDown').val($('#EmployeeStatusId').val());
    })
}
HRMS.GetAlluser = function (value) {
    
    $.getJSON("/JobDetailsCon/GetAlluser", function (response) {
        $(".EmployeeIdDropDown").empty();
        $(".EmployeeIdDropDown").append($("<option />").val(null).text("Select EmployeeIdDropDown"));
        $.each(response, function () {
            $(".EmployeeIdDropDown").append($("<option />").val(this.Id).text(this.Name));
        });
        if ($('#Employee.Id').val() != undefined) {
            $('.EmployeeIdDropDown').val($('#Employee.Id').val());
        }
        $('.EmployeeIdDropDown').val($('#Employee.Id').val());
    })
}

HRMS.BindAllCompany = function () {

    $.getJSON("/Company/GetAllCompany", function (response) {
        $(".companyAllDropdown").empty();
        $(".companyAllDropdown").append($("<option />").val(null).text("Select Company Name"));
        $.each(response, function () {
            $(".companyAllDropdown").append($("<option />").val(this.Id).text(this.CompanyName));
        });
        if ($('#cID').val() != undefined) {
            $('.companyAllDropdown').val($('#cID').val());
        }
    })

}

$(function () {
    HRMS.BindCurrency();
    HRMS.BindCountry();
    HRMS.BindEmployeeType();
    HRMS.ConfimrDelete();
    HRMS.BindDepartmentType();
    HRMS.BindCompany();
    
    HRMS.BindAllCompany();
    //HRMS.BindBranch();
    HRMS.BindChangeDll();
    HRMS.BindAllBranch();
    HRMS.BindAllDepartments();
    HRMS.GetAllDesgination();
    HRMS.GetAllEmployeeTpye();
    HRMS.GetAllEmployeeRole();
    HRMS.GetAllEmployeeSubType();
    HRMS.GetAllEmployeeStatus();
    HRMS.GetAlluser();
});
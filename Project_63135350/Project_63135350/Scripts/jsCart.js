$(document).ready(function () {
    ShowCount();
    $('body').on('click', '.btnAddToCart', function (e) {
        e.preventDefault();
        var id = $(this).data('id');
        var quatity = 1;
        var tQuantity = $('#quantity_value').text();
        if (tQuantity != '') {
            quatity = parseInt(tQuantity);
        }
        $.ajax({
            url: '/ShoppingCart_63135350/AddToCart',
            type: 'POST',
            data: { id: id, quantity: quatity },
            success: function (rs) {
                if (rs.Success) {
                    $('#checkout_items').html(rs.Count);
                    alert(rs.msg);
                }
            }
        });
    });
    $('body').on('click', '.btnUpdate', function (e) {
        e.preventDefault();
        var id = $(this).data("id");
        var quanlity = $('#Quanlity_' + id).val();
        Update(id, quanlity);
    });
    $('body').on('click', '.btnDeleteAll', function (e) {
        e.preventDefault();
        var conf = confirm('Bạn có muốn xóa hết sản phẩm khỏi giỏ hàng không?');
        if (conf == true) {
            DeleteAll();
        }

    });
    $('body').on('click', '.btnDelete', function (e) {
        e.preventDefault();
        var id = $(this).data('id');
        var conf = confirm('Bạn có muốn xóa sản phẩm này khỏi giỏ hàng không?');
        if (conf == true) {
            $.ajax({
                url: '/ShoppingCart_63135350/Delete',
                type: 'POST',
                data: { id: id },
                success: function (rs) {
                    if (rs.Success) {
                        $('#checkout_items').html(rs.Count);
                        $('#trow_' + id).remove();
                        LoadCart();
                    }
                }
            });
        }
        
    });
});
function ShowCount() {
    $.ajax({
        url: '/ShoppingCart_63135350/ShowCont',
        type: 'GET',
        success: function (rs) {
            $('#checkout_items').html(rs.Count);
             
        }
    });
}
function DeleteAll() {
    $.ajax({
        url: '/ShoppingCart_63135350/DeleteAll',
        type: 'POST',
        success: function (rs) {
            if (rs.Success) {
                LoadCart();
            }

        }
    });
}
function Update(id, quanlity) {
    $.ajax({
        url: '/ShoppingCart_63135350/Update',
        type: 'POST',
        data: { id: id, quanlity: quanlity },
        success: function (rs) {
            if (rs.Success) {
                LoadCart();
            }

        }
    });
}

function LoadCart() {
    $.ajax({
        url: '/ShoppingCart_63135350/Partial_Item_Cart',
        type: 'GET',
        success: function (rs) {
            $('#load_data').html(rs);

        }
    });
}
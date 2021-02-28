Imports COH.CodeManagement.Enums.Accounts

Namespace Accounts.Inventories
    Public NotInheritable Class AccountInventorySet
        '
        '    Creating an inventory set -
        '        -    Method 1: 
        '                1. eaPush() the AccountInventory* objects on the invArr.
        '                2. Call AccountInventorySet_Sort() to index the entire array.
        '        -    Method 2:
        '                1. Call AccountInventorySet_AddAndSort() for each item you want to add.
        '
        '    Destroying an inventory set -
        '        -    Call AccountInventorySet_Release() to release the index data and.
        '
        '    Finding an item in an inventory set -
        '        -    ***DO NOT*** use a for-loop! That technique won't scale as users potentially come
        '            to own dozens or even hundreds of products.
        '        -    DO use the inventory set lookup functions:
        '                AccountInventorySet_Find() - to find an AcccountInventory item.
        '
        Public Property AccountStatus As AccountStatusFlags
        Public Property AccountInventories As AccountInventory()
    End Class
End Namespace

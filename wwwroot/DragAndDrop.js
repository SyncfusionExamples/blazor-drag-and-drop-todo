var dragCardId = null;

function DragStart(args, id) {
    dragCardId = id;
}

function DropCard(args) {
    var dropElement = document.elementFromPoint(args.clientX, args.clientY);
    var IsDroppedOnCompletedPane = dropElement.closest('.e-accordion') ? true : false;
    var dropCard = dropElement.closest('.taskitem');
    DotNet.invokeMethodAsync('DragDrop', 'UpdateCards', IsDroppedOnCompletedPane, dragCardId, dropCard != null ? dropCard.id : null);
}
# coding=utf-8
# --------------------------------------------------------------------------
# Code generated by Microsoft (R) AutoRest Code Generator 1.2.0.0
# Changes may cause incorrect behavior and will be lost if the code is
# regenerated.
# --------------------------------------------------------------------------

from msrest.serialization import Model


class CheckNameAvailabilityResult(Model):
    """The CheckNameAvailability operation response.

    :param name_available: Gets a boolean value that indicates whether the
     name is available for you to use. If true, the name is available. If
     false, the name has already been taken or invalid and cannot be used.
    :type name_available: bool
    :param reason: Gets the reason that a storage account name could not be
     used. The Reason element is only returned if NameAvailable is false.
     Possible values include: 'AccountNameInvalid', 'AlreadyExists'
    :type reason: str or :class:`Reason <storage.models.Reason>`
    :param message: Gets an error message explaining the Reason value in more
     detail.
    :type message: str
    """

    _attribute_map = {
        'name_available': {'key': 'nameAvailable', 'type': 'bool'},
        'reason': {'key': 'reason', 'type': 'Reason'},
        'message': {'key': 'message', 'type': 'str'},
    }

    def __init__(self, name_available=None, reason=None, message=None):
        self.name_available = name_available
        self.reason = reason
        self.message = message

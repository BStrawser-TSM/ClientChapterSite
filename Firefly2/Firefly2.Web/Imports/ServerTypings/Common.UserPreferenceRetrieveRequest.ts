﻿namespace Firefly2.Common {
    export interface UserPreferenceRetrieveRequest extends Serenity.ServiceRequest {
        PreferenceType?: string;
        Name?: string;
    }
}


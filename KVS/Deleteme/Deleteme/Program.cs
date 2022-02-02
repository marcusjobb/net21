using Deleteme;

//var cl = new QuickAndDirty();
//cl.FixPropertiesDefault(@"C:\Users\marcu\OneDrive - Software Skills International AB\Dokument\Net21\GitHub\KVS\Deleteme\");
//cl.FixPropertiesDefault(@"C:\Users\marcu\source\MMPro\DailyNotes\");
//cl.FixJsonPropertiesName(@"C:\Users\marcu\source\MMPro\DailyNotes\");
//cl.MongoPatch(@"C:\Users\marcu\source\MMPro\DailyNotes\");

var qd = new QuickAndDirtyNew();
// qd.AdaptPropertiesToMongoDB(@"C:\Users\marcu\source\MMPro\DailyNotes\");
//qd.NicerProperties(@"C:\Users\marcu\OneDrive - Software Skills International AB\Dokument\Net21\GitHub\KVS\Deleteme\Deleteme\Models\");
qd.AdaptPropertiesToMongoDB(@"C:\Users\marcu\OneDrive - Software Skills International AB\Dokument\Net21\GitHub\KVS\Deleteme\Deleteme\Models\");
